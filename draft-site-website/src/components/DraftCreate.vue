<template>
  <div class="DraftCreate blur" style="width:100%;height:100%">
    <div class="centerIt">
      <div class="modal-content">
        <DraftSettings @update-settings="createNewDraft" mode="Create" />
      </div>
    </div>
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
