import DraftHub from "./draft-hub";

const draftLobby = "draftLobby/";

export default class DraftLobbyHub extends DraftHub {
  constructor() {
    super(draftLobby);
  }

  async start(that) {
    this.connection.on("receiveDraftLobbyUpdate", lobby => {
      that.receiveDraftLobbyUpdate(lobby);
    });

    await super.start(that);
  }

  async getDraftLobby(token) {
    // eslint-disable-next-line no-debugger
    debugger;
    var lobby = await this.connection.invoke("GetUserLobby", { Token: token });
    return lobby;
  }

  async createDraft(draft) {
    var createDraftResponse = await this.connection.invoke(
      "CreateDraft",
      draft
    );
    return createDraftResponse;
  }
}
