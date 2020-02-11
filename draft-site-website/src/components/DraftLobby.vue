<template>
  <div class="DraftLobby">
    <div id="main">
      <b-table hover :items="draftData">
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
  </div>
</template>

<script>
import { mapActions, mapState } from "vuex";

export default {
  async mounted() {
    await this.loadDraftLobby();
  },
  methods: {
    ...mapActions({
      loadDraftLobby: "draft/loadDraftLobby"
    })
  },
  computed: {
    ...mapState({
      draftData: state => state.draft.drafts
    })
  }
};
</script>

<style scoped></style>
