<template>
  <div class="DraftPre" style="width:100%;height:100%;">
    <div id="main" style="width:100%;height:100%;">
      <div class="grid-container" style="width:100%;height:100%;padding:0px;">
        <div class="mainArea">
          <!-- MAIN SWITCHING AREA -->
          <div
            class="teamPlayersArea"
            style="border-width: 0px 2px 0px 2px;border-style: solid;border-color:#949494;"
          >
            <!-- TEAMS -->
            <div
              id="teamArea"
              style="display:block;background-color:#F5F5F5;height:100%;"
            >
              TEAMS
            </div>
            <!-- PLAYERS -->
            <div
              id="playersArea"
              style="display:none;background-color:#F5F5F5;height:100%;"
            >
              PLAYERS
            </div>
          </div>
          <!-- TOP SWITCHING BUTTONS -->
          <div
            class="teamPlayersLabelArea"
            style="width:100%;height:100%;padding:0px;border-width: 2px 2px 2px 2px;border-style: solid;border-color:#212931;"
          >
            <div class="teamLabelArea" style="">
              <a
                href="#"
                class="button fit "
                onclick="teamSwitch()"
                id="btnTeamSwitch"
                >Teams</a
              >
            </div>
            <div class="playerLabelArea">
              <a
                href="#"
                class="button fit primary"
                onclick="playerSwitch()"
                id="btnPlayerSwitch"
                >Players</a
              >
            </div>
          </div>
        </div>
        <!-- DRAFT SETTINGS -->
        <div
          class="draftSettings"
          style="width:100%;height:100%;border-width: 2px 0px 0px 0px;border-style: solid;border-color:#212931;padding:10px;"
        >
          <DraftSettings @updateSettings="updateSettings" />
        </div>
        <!-- TODO: Brian, This doesn't look right here with the divs -->
      </div>
      <!-- CHAT -->
      <div id="chatMenu" class="box">
        <button
          class="open-button button fit small primary"
          onclick="openForm()"
        >
          Group Chat <i class="fas fa-angle-up"></i>
        </button>
        <div class="chat-popup" id="chatForm">
          <form action="#" class="form-container">
            <h5>Group Chat</h5>

            <div style="overflow: auto;max-height: 420px;"></div>

            <div
              style="background-color:white;height:40px;margin:5px;width:100%;"
            >
              <input
                type="text"
                id="msg"
                name="msg"
                placeholder="Type a message.."
                style="float:left;width:80%;height:40px;background-color:white;"
              />
              <button
                type="submit"
                class="btn"
                style="float:right;width:20%;height:40px;"
              >
                <i class="fas fa-paper-plane"></i>
              </button>
            </div>
          </form>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { mapActions, mapState } from "vuex";
import DraftSettings from "./DraftSettings.vue";
import PreDraftLobbyHub from "../hubs/pre-draft-lobby-hub.js";

export default {
  async mounted() {
    // await this.loadPreDraftLobby();
    this.preDraftLobbyHub = PreDraftLobbyHub;
  },
  data() {
    return {
      preDraftLobbyHub: ""
    };
  },
  components: {
    DraftSettings
  },
  methods: {
    ...mapActions({
      updateSettings: "draft/updateSettings"
    })
  },
  computed: {
    ...mapState({
      username: state => state.user.username
    }),
    isOwner: function() {
      return this.username == this.messageUsername;
    }
  }
};
</script>

<style scoped>
/* GRID LAYOUT */
.grid-container {
  display: grid;
  grid-template-columns: 80% 20%;
  grid-template-rows: 100%;
  grid-template-areas: "mainArea draftSettings";
}

.mainArea {
  display: grid;
  grid-template-columns: 100%;
  grid-template-rows: 8% 92%;
  grid-template-areas: "teamPlayersLabelArea" "teamPlayersArea";
  grid-area: mainArea;
}

.teamPlayersArea {
  grid-area: teamPlayersArea;
}

.teamPlayersLabelArea {
  display: grid;
  grid-template-columns: 50% 50%;
  grid-template-rows: 100%;
  grid-template-areas: "teamLabelArea playerLabelArea";
  grid-area: teamPlayersLabelArea;
}

.teamLabelArea {
  grid-area: teamLabelArea;
}

.playerLabelArea {
  grid-area: playerLabelArea;
}

.draftSettings {
  grid-area: draftSettings;
}

/* CHAT WINDOW */
/* The popup chat - hidden by default */
.chat-popup {
  width: 280px;
  display: none;
  position: fixed;
  bottom: 48px;
  right: 2%;
  /* margin-bottom: 0px; */
  z-index: 1;
}

.open-button {
  /* padding: 16px 20px; */
  border: none;
  cursor: pointer;
  position: fixed;
  bottom: 0%;
  right: 2%;
  width: 280px;
  height: 48px;
  z-index: 99;
}

/* Add styles to the form container */
.form-container {
  max-width: 300px;
  padding: 10px;
  background-color: white;
}

/* CHAT MESSAGES */
.containerMessage {
  border: 2px solid #dedede;
  background-color: #f1f1f1;
  border-radius: 5px;
  padding: 5px;
  margin: 5px 0;
}

.darker {
  border-color: #ccc;
  background-color: #ddd;
}

.containerMessage::after {
  content: "";
  clear: both;
  display: table;
}

.containerMessage img {
  float: left;
  max-width: 60px;
  width: 100%;
  margin-right: 20px;
  border-radius: 50%;
}

.containerMessage img.right {
  float: right;
  margin-left: 20px;
  margin-right: 0;
}

.user-right {
  float: right;
  color: #aaa;
}

.user-left {
  float: left;
  color: #999;
}
</style>
