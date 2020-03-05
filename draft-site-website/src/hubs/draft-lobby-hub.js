import DraftHub from "./draft-hub";

const draftLobby = "draftHub/";

export default class DraftLobbyHub extends DraftHub {
  constructor() {
    super(draftLobby);
  }

  async start(that) {
    this.connection.on("receiveDraftLobbyUpdate", drafts => {
      that.receiveDraftLobbyUpdate(drafts);
    });

    await super.start(that);
  }

  async enterDraftLobby(token) {
    var response = await this.connection.invoke("JoinDraftLobbyAsync", {
      Token: token
    });
    return response;
  }

  async updateDraftLobby() {
    await this.connection.invoke("updateDraftLobby");
  }

  async createDraft(draft) {
    var createDraftResponse = await this.connection.invoke(
      "CreateDraft",
      draft
    );
    return createDraftResponse;
  }
}
