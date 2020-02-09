<template>
  <div class="DraftLobby">
    {{ user.username }}
    <div id="main">
      <!-- Post -->
      <section class="post">
        <header class="major"></header>
      </section>
    </div>
    <b-table hover :items="drafts"></b-table>
  </div>
</template>

<script>
import { mapActions, mapState } from "vuex";

export default {
  data() {
    return {
      drafts: [],
      error: false,
      errorMessage: "",
      user: {}
    };
  },
  async mounted() {
    await this.loadDraftLobby("abc");
    this.user = this.userData;
    this.drafts = this.draftData;
  },
  methods: {
    ...mapActions({
      loadDraftLobby: "draft/loadDraftLobby"
    })
  },
  computed: {
    ...mapState({
      userData: state => state.draft.user,
      draftData: state => state.draft.drafts
    })
  }
};
</script>

<style scoped></style>
