<template>
  <div class="DraftCreate">
    <div id="main">
      <h2>Create Draft</h2>
      <b-form @submit="onSubmit" @reset="onReset">
        <b-form-input
          type="text"
          name="txtName"
          id="txtName"
          v-model="draftName"
          placeholder="Name"
        ></b-form-input>
        <b-form-select
          v-model="draftRoundSelected"
          :options="draftRounds"
        ></b-form-select>
        <b-form-select
          v-model="draftTimeSelected"
          :options="draftLookups.draftTimes"
          value-field="timeInSeconds"
          text-field="value"
        ></b-form-select>
        <b-form-checkbox v-model="isPublic" name="is-public-check-button" switch
          >Public?
        </b-form-checkbox>
        <div v-if="!isPublic">
          <b-form-input
            type="text"
            name="txtPassword"
            id="txtPassword"
            v-model="password"
            placeholder="Password"
          ></b-form-input>
        </div>
        <b-form-checkbox
          v-model="isComputerTeams"
          name="has-computer-teams-check-button"
          switch
          >Allow Computer Teams
        </b-form-checkbox>
        <b-form-checkbox
          v-model="isMultiSelect"
          name="has-multi-select-check-button"
          switch
          >Allow Multiple Team Selection
        </b-form-checkbox>
        <h3>Draft Start</h3>
        <input
          type="radio"
          id="rdoDraftStartAuto"
          name="rdoDraftStart"
          onclick="startDateSwitch();"
          checked
        />
        <label for="rdoDraftStartAuto">Automatic</label>
        <input
          type="radio"
          id="rdoDraftStartMan"
          name="rdoDraftStart"
          onclick="startDateSwitch();"
        />
        <label for="rdoDraftStartMan">Manual</label>
        <!-- Manual Date -->
        <h3>
          Select start date:
        </h3>
        <input
          type="date"
          name="tpManualDate"
          id="tpManualDate"
          value=""
          placeholder="CurrentDate"
        />
        <!-- Submit and reset Buttons -->
        <ul class="actions">
          <li>
            <input type="submit" value="Create" class="primary" />
          </li>
          <li><input type="reset" value="Reset" /></li>
        </ul>
      </b-form>
    </div>
  </div>
</template>

<script>
import { mapActions, mapState } from "vuex";

export default {
  data() {
    return {
      draftLookups: {},
      draftRounds: [
        { value: 3, text: 3 },
        { value: 4, text: 4 },
        { value: 5, text: 5 },
        { value: 6, text: 6 },
        { value: 7, text: 7 }
      ],
      draftRoundSelected: {},
      draftTimeSelected: {},
      errorMessage: "",
      isComputerTeams: false,
      isMultiSelect: false,
      isPublic: false,
      draftName: "",
      password: ""
    };
  },
  async mounted() {
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
      await this.createDraft({
        name: this.draftName,
        isComputerTeams: this.isComputerTeams,
        isMultiSelect: this.isMultiSelect,
        isPublic: this.isPublic,
        password: this.password,
        pickTime: this.draftTimeSelected,
        roundCount: this.draftRoundSelected
      });
    },
    onReset() {
      this.draftName = "";
      this.hasComputerTeams = false;
      this.isPublic = false;
      this.draftTimeSelected = {};
      this.draftRoundSelected = {};
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
.grid-container {
  display: grid;
  grid-template-columns: 50% 50%;
  grid-template-rows: 33% 33% 33%;
  grid-template-areas: "Public rdPublic" "comTeams rdComTeams" "draftStart rdDraftStart";
  width: 100%;
  text-align: left;
}

.Public {
  grid-area: Public;
}

.rdPublic {
  grid-area: rdPublic;
}

.comTeams {
  grid-area: comTeams;
}

.rdComTeams {
  grid-area: rdComTeams;
}

.draftStart {
  grid-area: draftStart;
}

.rdDraftStart {
  grid-area: rdDraftStart;
}
</style>
