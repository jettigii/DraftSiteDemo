import { HubConnectionBuilder, LogLevel } from "@aspnet/signalr";

const preDraftLobbyHubRoute = "preDraftLobby/";
let connection;

class PreDraftLobbyHub {
  constructor(that) {
    connection = new HubConnectionBuilder()
      .withUrl(process.env.VUE_APP_HUB + preDraftLobbyHubRoute)
      .configureLogging(LogLevel.Information)
      .build();

    connection.on("receiveChatMessage", message => {
      that.receiveMessage(message);
    });
  }

  async start() {
    await connection.start().catch(function() {});
  }

  async enterPreDraftLobby(that, draftId, password) {
    // eslint-disable-next-line no-console
    console.log(connection);
    return connection.invoke("enterPreDraftLobby", {
      draftId,
      password
    });
  }
}

export default PreDraftLobbyHub;
