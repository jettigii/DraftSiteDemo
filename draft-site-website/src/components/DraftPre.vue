<template>
  <div class="DraftPre" style="width:100%;height:100%;overflow: hidden;">
    <div id="main" style="width:100%;height:100%;">
      <div
        id="preGrid"
        class="grid-container"
        style="width:100%;height:100%;padding:0px;"
      >
        <div class="mainArea">
          <!-- MAIN SWITCHING AREA -->
          <div class="teamPlayersArea">
            <!-- style="border-width: 0px 2px 0px 2px;border-style: solid;border-color:#949494;" -->
            <!-- TEAMS -->
            <div id="teamArea" class="teamPlayerAreas">
              <div class="DraftCreate blur" style="width:100%;height:100%;">
                <br />
                <div class="centerIt" style="height:100%;">
                  <div
                    class="modal-content"
                    style="height:90%;display: inline-block;overflow-y:auto;"
                  >
                    <!-- <h3 style="text-align:center;">Teams</h3> -->
                    <draft-team-component
                      v-for="item in preDraftLobby.draftTeams"
                      :key="item.teamName"
                      :teamName="item.teamName"
                      :teamOwner="item.teamOwnerUser"
                      @click.native="selectTeam(item)"
                    ></draft-team-component>
                  </div>
                </div>
              </div>
            </div>
            <!-- PLAYERS -->
            <div id="playersArea" class="teamPlayerAreas">
              <div class="DraftCreate blur" style="width:100%;height:100%;">
                <br />
                <div class="centerIt" style="height:100%;">
                  <div
                    class="modal-content"
                    style="height:90%;display: inline-block;overflow-y:auto;"
                  >
                    <!-- <h3 style="text-align:center;">Players</h3> -->
                    <draft-player-component
                      v-for="item in preDraftLobby.draftPlayers"
                      :key="item.playerName"
                      :playerName="item.playerName"
                      :playerCollege="item.playerCollege"
                    ></draft-player-component>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <!-- TOP SWITCHING BUTTONS (TEAMS | PLAYERS)-->
          <div
            class="teamPlayersLabelArea"
            style="width:100%;height:100%;padding:0px;border-width: 2px 2px 2px 2px;border-style: solid;border-color:#212931;"
          >
            <div class="teamLabelArea" style="">
              <a
                href="#"
                class="button fit primary"
                onclick="teamSwitch()"
                id="btnTeamSwitch"
                >Teams</a
              >
            </div>
            <div class="playerLabelArea">
              <a
                href="#"
                class="button fit "
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
          id="draftSettings"
          style="width:100%;height:100%;border-width: 2px 0px 0px 0px;border-style: solid;border-color:#212931;"
        >
          <div
            id="draftSettingsArrowToggle"
            style="height:100%;width:8%;float:left;background-color:#7E94A9;"
          >
            <button
              class=""
              style="height:100%;width:100%;color:white;border:none;background:none;padding:0;"
              onclick="draftSettingsSwitch()"
              id="btnSettingsToggle"
            >
              <i
                style="height:100%;width:100%;margin: 0;top: 50%;color:white;"
                id="draftSettingsArrow"
                class="fas fa-angle-right"
              ></i>
            </button>
          </div>

          <!-- <div style="float:right;width:80%;height:40px;"> -->
          <div id="draftSettingsContent" style="width:100%;height:100%;">
            <!-- DRAFT SETTINGS CONTENT -->
            <DraftSettings
              ref="draftSettings"
              style="width:100%;height:100%;"
              :draft="preDraftLobby.draft"
              :is-owner="preDraftLobby.isOwner"
              :lookups="preDraftLobby.lookups"
              mode="Update"
              @update-settings="updateSettings"
            />
            <button
              id="btnStartDraft"
              class="button primary"
              style="width:18.4%;position:absolute;bottom:0px;right:0px;"
              onclick="startDraft()"
            >
              Start Draft
            </button>
          </div>
        </div>
      </div>
      <!-- CHAT -->
      <div id="chatMenu" class="box">
        <button
          id="open-button"
          class="open-button button fit small primary"
          onclick="openForm()"
        >
          Group Chat <i class="fas fa-angle-up"></i>
        </button>
        <div class="chat-popup" id="chatForm">
          <h5>Group Chat</h5>

          <div style="overflow: auto;max-height: 420px;"></div>
          <!-- Messages go here -->
          <ChatBubble
            v-for="item in messages"
            :key="item.id"
            :messageUsername="item.username"
            :message="item.message"
          />
          <div
            style="background-color:white;height:40px;margin:5px;width:100%;"
          >
            <input
              v-model="message"
              type="text"
              id="msg"
              name="msg"
              placeholder="Type a message.."
              style="float:left;width:80%;height:40px;background-color:white;"
            />
            <button
              class="btn"
              style="float:right;width:20%;height:40px;"
              @click="sendMessage()"
            >
              <i class="fas fa-paper-plane"></i>
            </button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { mapActions, mapState } from "vuex";
import DraftSettings from "./DraftSettings.vue";
import ChatBubble from "./ChatBubble.vue";
import PreDraftLobbyHub from "../hubs/pre-draft-lobby-hub.js";
import DraftPlayerComponent from "./DraftPlayerComponent.vue";
import DraftTeamComponent from "./DraftTeamComponent.vue";

export default {
  props: {
    draftId: Number,
    password: String,
    lookups: Object
  },
  mounted: async function() {
    this.preDraftLobbyHub = new PreDraftLobbyHub();
    await this.preDraftLobbyHub.start(this);
    this.preDraftLobby = await this.preDraftLobbyHub.enterPreDraftLobby(
      this.draftId.toString(),
      this.password
    );
    // eslint-disable-next-line no-debugger
    debugger;
    this.$refs.draftSettings.loadSettings(this.preDraftLobby.draft);
  },
  data() {
    return {
      preDraftLobby: {},
      preDraftLobbyHub: {},
      message: "",
      messages: []
    };
  },
  components: {
    DraftSettings,
    ChatBubble,
    DraftPlayerComponent,
    DraftTeamComponent
  },
  methods: {
    ...mapActions({
      updateSettings: "draft/updateSettings"
    }),
    receiveMessage(message) {
      this.messages.push(message);
    },
    sendMessage: async function() {
      await this.preDraftLobbyHub.sendMessage(this.message);
      return false;
    },
    startDraft: function() {
      this.$emit("draftStatusChange", "In Progress");
    },
    selectTeam: function(team) {
      this.preDraftLobbyHub.selectTeam(team);
    }
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
  right: 22%;
  /* margin-bottom: 0px; */
  z-index: 1;
}

.open-button {
  /* padding: 16px 20px; */
  border-width: 2px;
  border-style: solid;
  border-color: #212931;
  cursor: pointer;
  position: fixed;
  bottom: 0%;
  right: 22%;
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

/* background */
.teamPlayerAreas {
  background-image: url("../assets/bg.jpg");
  background-repeat: no-repeat;
  background-size: cover;
  background-color: #212931;
  display: block;
  height: 100%;
}

.centerIt {
  display: inline-block;
  margin: 0 auto;
  padding: 3px;
  width: 90%;
  text-align: left;
}
</style>
