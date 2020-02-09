import Vue from "vue";
import Vuex from "vuex";
import draft from "./modules/draft.js";
import user from "./modules/user.js";

Vue.use(Vuex);

const debug = process.env.NODE_ENV !== "production";

export default new Vuex.Store({
  modules: {
    draft,
    user
  },
  strict: debug
});
