import Vue from "vue";
import Router from "vue-router";
import lobby from "./components/DraftLobby.vue";
import createDraft from "./components/DraftCreate.vue";
import home from "./components/Home.vue";
import preDraft from "./components/DraftPre.vue";
import draftRoom from "./components/DraftRoom.vue";

Vue.use(Router);

export default new Router({
  mode: "history",
  base: process.env.BASE_URL,
  routes: [
    {
      path: "/",
      name: "lobby",
      component: lobby
    },
    {
      path: "/createDraft",
      name: "createDraft",
      component: createDraft
    },
    {
      path: "/home",
      name: "home",
      component: home
    },
    {
      path: "/draftRoom/:draftId/:password?",
      name: "draftRoom",
      component: draftRoom,
      props: true
    },
    {
      path: "/preDraft",
      name: "preDraft",
      component: preDraft
    },
    {
      path: "*",
      name: "default",
      component: lobby
    }
  ]
});
