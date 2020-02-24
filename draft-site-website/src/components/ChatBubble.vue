<template>
  <div>
                 <!-- MESSAGE EXAMPLE -->
               <div class="containerMessage">
                 <img src="https://picsum.photos/255/255" alt="Avatar" style="width:100%;">
                 <p>{{ message }}</p>
                 <span class="user-right">{{ messageUsername }}</span>
               </div>
               <!-- MESSAGE EXAMPLE -->
  </div>
</template>

<script>
import { mapActions, mapState } from "vuex";

export default {
  components: {
  },
  data() {
    return {
      messageUsername: "",
      message: ""
    };
  },
  mounted: async function() {
    await this.loadDraftData();
    this.draftLookups = this.draftData;
  },
  methods: {
    ...mapActions({
      loadDraftData: "draft/loadDraftLookups",
      createDraft: "draft/createDraft"
    }),
    async onSubmit(evt) {
      evt.preventDefault();
      this.$emit("update-settings", this.createDraftObject());
    },
    onReset() {
      this.draftName = "";
      this.hasComputerTeams = false;
      this.isPublic = false;
      this.draftTimeSelected = {};
      this.draftRoundSelected = {};
    },
    createDraftObject: function() {
      return {
        isComputerTeams: this.isComputerTeams,
        isPublic: this.isPublic,
        isMultiSelect: this.isMultiSelect,
        name: this.draftName,
        password: this.password,
        pickTime: this.pickTime,
        roundCount: this.roundCount,
        startTime: this.startTime
      };
    }
  },
  computed: {
    ...mapState({
      draftData: state => state.draft.draftLookups
    })
  }
};
</script>

<style scoped>
@media only screen and (max-width: 600px) {
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
  margin-right:0;
}

.user-right {
  float: right;
  color: #aaa;
}

.user-left {
  float: left;
  color: #999;
}
</style>
