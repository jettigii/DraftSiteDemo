import DraftService from "../../services/draft-service.js";

const state = {
  createDraftResponse: {},
  drafts: [],
  draftLobbyError: "",
  draftLookups: "",
  lookupError: {},
  user: {}
};

// actions
const actions = {
  async createDraft({ commit }, draft) {
    const draftService = new DraftService();
    await draftService
      .createDraft(draft)
      .then(response => {
        commit("setCreateDraftResponse", response);
      })
      .catch(error => {
        commit("setCreateDraftResponse", error);
      });
  },
  async loadDraftLobby({ commit }) {
    const draftService = new DraftService();

    await draftService
      .getDrafts()
      .then(response => {
        commit("setDraftLobby", response.data);
      })
      .catch(error => {
        commit("setDraftLobby", []);
        commit("setDraftLobbyFail", error.response.data.errors);
      });
  },
  async loadDraftLookups({ commit }) {
    const draftService = new DraftService();

    await draftService
      .getDraftLookups()
      .then(response => {
        commit("setDraftLookups", response.data);
      })
      .catch(error => {
        commit("setDraftLookupError", error);
      });
  }
};

// mutations
const mutations = {
  setCreateDraftResponse(state, createDraftResponse) {
    state.createDraftResponse = createDraftResponse;
  },
  setDraftLobby(state, drafts) {
    state.drafts = drafts;
  },
  setDraftLobbyFail(state, errors) {
    state.draftLobbyError = errors.join(" ");
  },
  setDraftLobbyUser(state, user) {
    state.user = user;
  },
  setDraftLookups(state, lookups) {
    state.draftLookups = lookups;
  },
  setDraftLookupError(state, error) {
    state.lookupError = error;
  }
};

export default {
  namespaced: true,
  state,
  actions,
  mutations
};
