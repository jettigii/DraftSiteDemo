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
            id="password-input"
            v-model="password"
            :state="passwordState"
            required
          ></b-form-input>
        </b-form-group>
      </form>
    </b-modal>
  </div>
</template>

<script>
import { mapActions, mapState } from "vuex";

export default {
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
      modalName: "modal-password-ref"
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
      this.selectedRow = row;
      // eslint-disable-next-line no-debugger
      // debugger;
      if (this.selectedRow.isPublic) {
        this.$router.push({
          name: "draftRoom",
          params: {
            draftId: this.selectedRow.id,
            status: this.selectedRow.draftStatus
          }
        });
      } else {
        // eslint-disable-next-line no-debugger
        // debugger;
        this.$refs["modal-password-ref"].show();
        // eslint-disable-next-line no-debugger
        // debugger;
      }
    },
    handleOk(e) {
      e.preventDefault();

      this.$nextTick(() => {
        this.$bvModal.hide(this.modalName);
      });

      if (!this.password) {
        // Todo Brian add alert that you must provide password
      }

      // eslint-disable-next-line no-debugger
      // debugger;

      if (this.selectedRow.id && this.selectedRow.draftStatus)
        this.$router.push({
          name: "draftRoom",
          params: {
            draftId: this.selectedRow.id,
            password: this.password,
            status: this.selectedRow.draftStatus
          }
        });
      else {
        // Todo Brian add alert that there was an error, though this should never happen
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
