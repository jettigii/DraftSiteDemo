import UserService from "../../services/user-service.js";

const state = {
  user: null
};

// actions
const actions = {
  async authenticate({ commit }, user) {
    const userService = new UserService();

    await userService
      .authenticate({
        token: user
      })
      .then(response => {
        commit("setUser", response.data);
      })
      .catch(error => {
        commit("setLoginError", error.response.data.errors);
      });
  }
};

// mutations
const mutations = {
  setLoginError(state, user) {
    state.user.loginError = user;
  },
  setUser(state, user) {
    state.user = user;
  }
};

export default {
  namespaced: true,
  state,
  actions,
  mutations
};
