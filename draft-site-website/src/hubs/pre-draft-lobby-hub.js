import { HubConnectionBuilder, LogLevel } from "@aspnet/signalr";

const preDraftLobbyHubRoute = "preDraftLobby/";
let connection;

class PreDraftLobbyHub {
  constructor() {
    connection = new HubConnectionBuilder()
      .withUrl(process.env.VUE_APP_HUB + preDraftLobbyHubRoute)
      .configureLogging(LogLevel.Information)
      .build();
  }

  async start(that) {
    connection.on("receiveChatMessage", message => {
      that.receiveMessage(message);
    });

    connection.on("receiveSettingsUpdate", settings => {
      that.recieveSettings(settings);
    });

    connection.on("receiveTeamsUpdate", teams => {
      that.recieveSettings(teams);
    });

    await connection.start().catch(function() {});
  }

  async enterPreDraftLobby(draftId, password) {
    // eslint-disable-next-line no-console
    console.log(connection);
    const preDraftLobby = await connection.invoke("enterPreDraftLobby", {
      draftId,
      password
    });
    // eslint-disable-next-line no-console
    console.log(preDraftLobby);
    return preDraftLobby;
  }

  async sendMessage(message) {
    // eslint-disable-next-line no-console
    console.log(connection);
    const preDraftLobby = await connection.invoke("sendMessage", message);
    // eslint-disable-next-line no-console
    console.log(preDraftLobby);
    return preDraftLobby;
  }
}

export default PreDraftLobbyHub;
