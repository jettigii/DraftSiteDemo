<template>
  <div>
    <component
      v-bind:is="draftComponent"
      :draftId="draftId"
      :password="password"
      @draftStatusChange="draftStatusChange"
      @updateDraftLobby="updateDraftLobby"
    />
  </div>
</template>

<script>
import PreDraftLobby from "./DraftPre.vue";
import Draft from "./MultiDraftPick.vue";

export default {
  props: {
    draftId: Number,
    password: String,
    status: String
  },
  components: {
    PreDraftLobby,
    Draft
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
  },
  methods: {
    draftStatusChange(newStatus) {
      this.status = newStatus;
    },
    updateDraftLobby() {
      this.$emit("updateDraftLobby");
    }
  }
};
</script>

<style scoped></style>
