<template>
  <div class="DraftLobby">
    <div id="main">
      <b-table
        hover
        :items="draftData"
        @row-clicked="enterDraft"
        :fields="draftFields"
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
      </b-table>
    </div>
    <div>
      <b-modal
        id="modal-password"
        ref="modal"
        title="Submit draft password"
        @show="resetModal"
        @hidden="resetModal"
        @ok="enterDraft"
      >
        <form ref="form" @submit.stop.prevent="enter">
          <b-form-group
            label="Password"
            label-for="password-input"
            invalid-feedback="Password is required"
          >
            <b-form-input
              id="password-input"
              v-model="password"
              :state="passwordState"
              required
            ></b-form-input>
          </b-form-group>
        </form>
      </b-modal>
    </div>
  </div>
</template>

<script>
import { mapActions, mapState } from "vuex";

export default {
  data() {
    return {
      password: "",
      passwordState: null,
      draftFields: [
        { key: "name" },
        { key: "roundCount" },
        { key: "pickTime" },
        { key: "startTime" },
        { key: "isMultiSelect", label: "Multiple Team Selection" },
        { key: "isComputerTeams", label: "Computer Players Allowed" },
        { key: "isPublic" },
        { key: "username", label: "Manager" }
      ]
    };
  },
  async mounted() {
    await this.loadDraftLobby();
  },
  methods: {
    ...mapActions({
      loadDraftLobby: "draft/loadDraftLobby"
    }),
    enterDraft: function(row) {
      if (row.isPublic) {
        this.$router.push({
          name: "draftRoom",
          params: {
            draftId: row.id,
            status: row.draftStatus
          }
        });
      }
    },
    resetModal() {
      this.name = "";
      this.nameState = null;
    }
  },
  computed: {
    ...mapState({
      draftData: state => state.draft.drafts
    })
  }
};
</script>

<style scoped></style>
