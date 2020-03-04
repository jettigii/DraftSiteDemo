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

  async enterPreDraftLobby(userId, draftId, password) {
    const preDraftLobby = await connection.invoke("enterPreDraftLobby", {
      userId,
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
    const response = await connection.invoke("selectTeam", {
      TeamName: team.teamName
    });
    return response;
  }

  async updateSettings(settings) {
    // eslint-disable-next-line no-console
    console.log(settings);
    await connection.invoke("updateSettings", settings);
  }

  async startDraft() {}
}

export default PreDraftLobbyHub;
