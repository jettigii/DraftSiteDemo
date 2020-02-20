<template>
  <div>
    <component
      v-bind:is="draftComponent"
      :draftId="draftId"
      :password="password"
    />
  </div>
</template>

<script>
import PreDraftLobby from "./DraftPre.vue";

export default {
  props: {
    draftId: Number,
    password: String,
    status: String
  },
  components: {
    PreDraftLobby
  },
  computed: {
    draftComponent: function() {
      if (this.status == "In Progress" || this.status == "Paused") {
        return "Draft";
      } else if (this.status == "Completed") {
        return "PostDraftLobby";
      } else if (this.status == "Canceled") {
        return "Lobby";
      } else {
        return "PreDraftLobby";
      }
    }
  }
};
</script>

<style scoped></style>
