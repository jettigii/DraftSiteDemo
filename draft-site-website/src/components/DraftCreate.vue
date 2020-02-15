<template>
  <div class="DraftCreate blur" style="width:100%;height:100%">
    <DraftSettings @updateSettings="createNewDraft" />
  </div>
</template>

<script>
import { mapActions } from "vuex";
import DraftSettings from "./DraftSettings.vue";

export default {
  components: {
    DraftSettings
  },
  methods: {
    ...mapActions({
      createDraft: "draft/createDraft"
    }),
    async createNewDraft(draft) {
      await this.createDraft(draft);
      this.$router.push("/lobby");
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
</style>
