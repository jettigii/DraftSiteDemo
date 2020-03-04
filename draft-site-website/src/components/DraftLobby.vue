<template>
  <div class="DraftLobby">
    <div id="main">
      <div
        id="preGrid"
        class="grid-container"
        style="width:100%;height:100%;padding:0px;"
      >
        <b-table
          hover
          :items="draftLobby.drafts"
          @row-clicked="enterDraft"
          :fields="draftFields"
          :busy="isLoading"
        >
          <template v-slot:cell(isComputerTeams)="data">
            <b class="text-info">{{ data.value | yesno }}</b>
          </template>
          <template v-slot:cell(isMultiSelect)="data">
            <b class="text-info">{{ data.value | yesno }}</b>
          </template>
          <template v-slot:cell(isPublic)="data">
            <b class="text-info">{{ data.value | yesno }}</b>
          </template>

          <template v-slot:table-busy>
            <div class="text-center text-danger my-2">
              <b-spinner class="align-middle"></b-spinner>
              <strong>Loading...</strong>
            </div>
          </template>
        </b-table>
      </div>
      <b-modal
        id="modal-password-id"
        ref="modal-password-ref"
        title="Submit draft password"
        @show="resetModal"
        @hidden="resetModal"
        @ok="handleOk"
      >
        <form ref="form" @submit.stop.prevent="handleOk">
          <b-form-group
            label="Password"
            label-for="password-input"
            invalid-feedback="Password is required"
          >
            <b-form-input
              :autofocus="true"
              id="password-input"
              v-model="password"
              type="password"
              :state="passwordState"
              required
            ></b-form-input>
          </b-form-group>
        </form>
      </b-modal>

      <!-- <div style="float:right;width:80%;height:40px;"> -->
      <!-- <div id="draftSettingsContent" style="width:100%;height:100%;"> -->
      <!-- DRAFT SETTINGS CONTENT -->
      <draft-settings
        @update-settings="createDraft"
        mode="Create"
        :lookups="draftLobby.lookups"
      />
    </div>
    <chat-room
      ref="chatRoom"
      :username="draftLobby.user.username"
      @send-message="sendMessage"
    ></chat-room>
  </div>
</template>

<script>
import ChatRoom from "./ChatRoom.vue";
import DraftLobbyHub from "../hubs/draft-lobby-hub.js";
import DraftSettings from "./DraftSettings.vue";

export default {
  components: {
    ChatRoom,
    DraftSettings
  },
  data() {
    return {
      password: "",
      passwordState: null,
      selectedRow: null,
      draftFields: [
        { key: "name" },
        { key: "roundCount" },
        { key: "pickTime" },
        { key: "startTime" },
        { key: "isMultiSelect", label: "Multiple Team Selection" },
        { key: "isComputerTeams", label: "Computer Players Allowed" },
        { key: "isPublic" },
        { key: "username", label: "Manager" }
      ],
      modalName: "modal-password-ref",
      draftLobbyHub: null,
      draftLobby: {
        drafts: [],
        lookups: {},
        user: {
          username: "Not logged in"
        }
      },
      isLoading: false
    };
  },
  mounted: async function() {
    this.isLoading = true;
    this.draftLobbyHub = new DraftLobbyHub();
    await this.draftLobbyHub.start(this);

    this.draftLobby = await this.draftLobbyHub.enterDraftLobby(
      "144f7dcfbc744fa7effd0f78eb0890d81af919725fd696d7e10b458ae34728c9"
    );

    await this.$store.commit("user/setUser", this.draftLobby.user);
    await this.$store.commit("draft/setDraftLookups", this.draftLobby.lookups);
    this.isLoading = false;
  },
  methods: {
    enterDraft: function(row) {
      this.selectedRow = row;

      if (!this.selectedRow.isPublic) {
        this.$refs["modal-password-ref"].show();
      } else {
        this.$emit("open-draft", this.selectedRow, "");
      }
    },
    receiveDraftLobbyUpdate: function(lobby) {
      this.draftLobby.drafts = lobby;
    },
    handleOk(e) {
      e.preventDefault();

      this.$nextTick(() => {
        this.$bvModal.hide(this.modalName);
      });

      if (!this.password) {
        // Todo Brian add alert that you must provide password
      }

      if (this.selectedRow.id && this.selectedRow.draftStatus) {
        this.selectedRow.password = this.password;
        this.$emit("open-draft", this.selectedRow);
        this.$refs["modal-password-ref"].hide();
      } else {
        // Todo Brian add alert that there was an error, though this should never happen
      }
    },
    resetModal() {
      this.name = "";
      this.nameState = null;
    },
    async createDraft(draft) {
      await this.draftLobbyHub.createDraft(draft);
      this.drafts = await this.draftLobbyHub.getDraftLobby();
    },
    receiveMessage(message) {
      this.$refs.chatRoom.receiveMessage(message);
    },
    sendMessage: async function(message) {
      await this.draftLobbyHub.sendMessage(message);
      return false;
    },
    updateDraftLobby(drafts) {
      this.draftLobby.drafts = drafts;
    }
  }
};
</script>

<style scoped>
.blur {
  background-image: url("../assets/bg.jpg");
  background-repeat: no-repeat;
  background-size: cover;
}
.centerIt {
  display: inline-block;
  margin: 0 auto;
  padding: 3px;
  width: 60%;
  text-align: left;
}

@media only screen and (max-width: 600px) {
  .centerIt {
    display: inline-block;
    margin: 0 auto;
    padding: 3px;
    width: 90%;
    text-align: left;
  }
}
</style>
