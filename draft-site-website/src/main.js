import Vue from "vue";
import Vuex from "vuex";
import store from "./store/index.js";
import App from "./App.vue";
import router from "./router";
import BootstrapVue from "bootstrap-vue";
import "bootstrap/dist/css/bootstrap.css";
import "bootstrap-vue/dist/bootstrap-vue.css";
import PreDraftLobbyHub from "./hubs/pre-draft-lobby-hub.js";

Vue.config.productionTip = false;
Vue.use(BootstrapVue);
Vue.use(Vuex);

Vue.use(PreDraftLobbyHub);

Vue.filter("yesno", function(value) {
  return value ? "Yes" : "No";
});

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount("#app");
