import { HubConnectionBuilder, LogLevel } from "@aspnet/signalr";

export default class DraftHub {
  constructor(endpoint) {
    this.connection = new HubConnectionBuilder()
      .withUrl(process.env.VUE_APP_HUB + endpoint)
      .configureLogging(LogLevel.Information)
      .build();
  }

  async start(that) {
    this.connection.on("receiveMessage", message => {
      that.receiveMessage(message);
    });

    await this.connection.start().catch(function() {});
  }

  async sendMessage(message) {
    const sendMessageResponse = await this.connection.invoke(
      "sendMessage",
      message
    );
    return sendMessageResponse;
  }
}
