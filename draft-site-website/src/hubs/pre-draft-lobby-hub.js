import { HubConnectionBuilder, LogLevel } from "@aspnet/signalr";
const preDraftLobbyHub = "preDraftLobby/";

export default {
  install() {
    const connection = new HubConnectionBuilder()
      .withUrl(process.env.VUE_APP_HUB + preDraftLobbyHub)
      .configureLogging(LogLevel.Information)
      .build();

    connection.start();
  }
};
