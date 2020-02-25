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
    connection.on("receiveMessage", message => {
      that.receiveMessage(message);
    });

    connection.on("receiveSettingsUpdate", settings => {
      that.receiveSettings(settings);
    });

    connection.on("receiveTeamsUpdate", teams => {
      that.receiveTeams(teams);
    });

    connection.on("receiveDraftStatus", draftStatus => {
      that.receiveDraftStatus(draftStatus);
    });

    await connection.start().catch(function() {});
  }

  async enterPreDraftLobby(draftId, password) {
    const preDraftLobby = await connection.invoke("enterPreDraftLobby", {
      draftId,
      password
    });
    return preDraftLobby;
  }

  async sendMessage(message) {
    const preDraftLobby = await connection.invoke("sendMessage", message);
    return preDraftLobby;
  }

  async selectTeam(team) {
    const response = await connection.invoke("selectTeam", team);
    return response;
  }

  async startDraft() {}
}

export default PreDraftLobbyHub;
