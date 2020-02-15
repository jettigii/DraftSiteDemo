<template>
  <div id="main" style="background-color: rgba(0, 0, 0, 0); width:100%">
    <div class="centerIt">
      <div class="modal-content">
        <b-form @submit="onSubmit" @reset="onReset">
          <div class="modal-body">
            <div class="actions">
              <label for="txtName">Name</label>
              <b-form-input
                type="text"
                name="txtName"
                id="txtName"
                v-model="draftName"
                placeholder="Name"
              ></b-form-input>
            </div>
            <br />
            <div
              class="actions"
              style="display:inline-block; text-align:left; width:40%;"
            >
              <label for="draftRoundSelected">Draft Rounds</label>
              <b-form-select
                v-model="roundCount"
                :options="draftRounds"
                id="draftRoundSelected"
              ></b-form-select>
            </div>

            <!-- Spacer -->
            <div style="display:inline-block; text-align:left; width:5%;"></div>

            <div
              class="actions"
              style="display:inline-block; text-align:left; width:40%;"
            >
              <label for="draftRoundSelected">Draft Time</label>
              <b-form-select
                v-model="pickTime"
                :options="draftLookups.draftTimes"
                value-field="timeInSeconds"
                text-field="value"
              ></b-form-select>
            </div>

            <br /><br />

            <b-form-checkbox
              v-model="isPublic"
              name="is-public-check-button"
              switch
              size="sm"
              ><label>Public?</label>
            </b-form-checkbox>

            <div v-show="!isPublic">
              <label for="txtPassword">Password</label>
              <b-form-input
                type="password"
                name="txtPassword"
                id="txtPassword"
                v-model="password"
                placeholder="password"
              ></b-form-input>
            </div>

            <b-form-checkbox
              v-model="isComputerTeams"
              name="has-computer-teams-check-button"
              switch
              size="sm"
              ><label>Allow Computer Teams</label>
            </b-form-checkbox>

            <b-form-checkbox
              v-model="isMultiSelect"
              name="has-multi-select-check-button"
              switch
              size="sm"
              ><label>Allow Multiple Team Selection</label>
            </b-form-checkbox>

            <div
              class="actions"
              style="display:inline-block; margin-right:10px; text-align:left;"
            >
              <label>Draft Start</label>
            </div>

            <b-form-radio-group
              v-model="selected"
              :options="options"
              class="mb-3"
              value-field="item"
              text-field="name"
              disabled-field="notEnabled"
            >
            </b-form-radio-group>

            <datetime
              format="YYYY-MM-DD h:i:s"
              width="300px"
              v-model="startTime"
            ></datetime>
          </div>

          <!-- Submit and reset Buttons -->
          <div class="modal-footer">
            <ul class="actions">
              <li>
                <input type="submit" value="Create" class="primary" />
              </li>
              <li><input type="reset" value="Reset" /></li>
            </ul>
          </div>
        </b-form>
      </div>
    </div>
  </div>
</template>

<script>
import { mapActions, mapState } from "vuex";
import datetime from "vuejs-datetimepicker";

export default {
  components: {
    datetime
  },
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
      isComputerTeams: false,
      isPublic: false,
      isMultiSelect: false,
      draftName: "",
      password: "",
      pickTime: {},
      roundCount: 3,
      startTime: "",
      selected: "Manual",
      options: [
        { item: "Manual", name: "Manual" },
        { item: "Automatic", name: "Automatic", notEnabled: true }
      ]
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
      this.$emit("updateSettings");
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
