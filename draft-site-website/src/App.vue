<template>
  <div id="app">
    <!-- <img alt="Vue logo" src="./assets/logo.png"> -->

    <!-- Nav -->
    <nav id="nav">
      <ul class="links">
        <li class="active"><router-link to="home">Draft Logo</router-link></li>
        <li><router-link to="/lobby">Draft Lobby</router-link></li>
      </ul>
      {{ userData.username }}
    </nav>

    <div style="width:100%; height:100%; padding-top: 100px;">
      <b-tabs content-class="mt-3">
        <b-tab title="Main Lobby" active>
          <draft-lobby @open-draft="openDraft"></draft-lobby>
        </b-tab>
        <b-tab v-for="tab in tabs" :key="tab.draftId">
          <b-button
            size="sm"
            variant="danger"
            class="float-right"
            @click="closeTab(i)"
          >
            Close tab
          </b-button>
          <draft-room
            :draftId="tab.id"
            :password="tab.password"
            :status="tab.draftStatus"
          ></draft-room>
        </b-tab>
      </b-tabs>
    </div>

    <!-- Copyright -->
    <!-- <div id="copyright">
      <ul>
        <li>&copy; 2020</li>
        <li>Designed by: FiniTech Inc.</li>
      </ul>
    </div> -->
  </div>
</template>

<script>
import { mapState } from "vuex";
// import DraftHub from "./hubs/draft-hub.js";
import DraftLobby from "./components/DraftLobby.vue";
import DraftRoom from "./components/DraftRoom.vue";

export default {
  name: "app",
  data() {
    return {
      tabs: []
    };
  },
  components: {
    DraftLobby,
    DraftRoom
  },
  computed: {
    ...mapState({
      userData: state => state.user.user
    })
  },
  methods: {
    openDraft(row) {
      this.tabs.push(row);
      // focus new tab
    },
    closeTab(x) {
      for (let i = 0; i < this.tabs.length; i++) {
        if (this.tabs[i] === x) {
          this.tabs.splice(i, 1);
        }
      }
    }
  }
};
</script>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin: 0px;
  /* margin-top: 100px; */
  height: 100%;
  width: 100%;
}
#nav {
  border-bottom-width: 5px;
  /* border-color: goldenrod; */
  border-color: red;
  border-style: solid;
}
</style>
