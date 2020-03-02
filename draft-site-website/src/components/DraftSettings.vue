<template>
<div>
  <div id="btnDraftMobileMenu">
    <button class="primary button" onclick="DraftMobileMenuClick()">
      <i id="btnDraftMobileMenuIcon" class="fas fa-bars"></i>
    </button>
  </div>
  <div
    id="DraftSettings"
  >
  
        <div
          id="draftSettingsArrowToggle" 
          style="height:100%;width:8%;float:left;background-color:#7E94A9;"
        >
          <button
            class=""
            style="height:100%;width:100%;color:white;border:none;background:none;padding:0;"
            onclick="draftSettingsSwitch()"
            id="btnSettingsToggle"
          >
            <i
              style="height:100%;width:100%;margin: 0;top: 50%;color:white;"
              id="draftSettingsArrow"
              class="fas fa-angle-right"
            ></i>
          </button>
        </div>

      <div id="draftSettingsContent">
        <b-form id="draftSettingsContentForm" @submit="onSubmit" @reset="onReset">
          <div class="">
            <div class="actions">
              <h5 class="modal-title" style="text-align:left;">
                Draft Settings
              </h5>
              <label for="txtName">Name</label>
              <b-form-input
                type="text"
                name="txtName"
                id="txtName"
                v-model="draftName"
                placeholder="Name"
                pattern="[A-Za-z0-9]{3,24}"
                title="Must be 3 to 24 characters and contain only letters and numbers only, no punctuation or special characters"
                required
                style="font-size:14pt;height:40px;"
              ></b-form-input>
            </div>
            <br />
            <div
              class="actions"
              style="display:inline-block; text-align:left; width:40%;"
            >
              <label for="draftRoundSelected">Draft Rounds</label>
              <b-form-select
                required
                v-model="roundCount"
                :options="draftRounds"
                id="draftRoundSelected"
                style="font-size:14pt;height:40px;"
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
                required
                v-model="pickTime"
                :options="lookups.draftTimes"
                value-field="timeInSeconds"
                text-field="value"
                style="font-size:14pt;height:40px;"
              ></b-form-select>
            </div>

            <br /><br />

            <b-form-checkbox
              v-model="isPublic"
              name="is-public-check-button"
              switch
              size="sm"
              value="true"
              ><label>Public draft?</label>
            </b-form-checkbox>

            <div v-show="showPassword" style="font-size:14pt;height:40px;">
              <b-form-input
                style="font-size:14pt;height:40px;width:60%;"
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
              style="font-size:14pt;height:40px;"
            >
            </b-form-radio-group>

            <!-- <datetime
              id="startTime"
              v-show="selected"
              format="YYYY-MM-DD h:i:s"
              width="300px"
              v-model="startTime"
              inline="true"
            >
            </datetime> -->
            <datetime
              id="startTime"
              type="datetime"
              v-model="datetime"
              use12-hour
              style="font-size:12pt;height:14px;z-index:999;"
            ></datetime>
          </div>
          <br /><br />
          <!-- Submit and reset Buttons -->
          <!-- <div class="modal-footer"> -->
          <div>
            <ul class="actions">
              <li>
                <input type="submit" :value="mode" class="primary" />
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
import { Datetime } from "vue-datetime";

export default {
  components: {
    // datetime
    datetime: Datetime
  },
  props: {
    draft: Object,
    isOwner: Boolean,
    mode: String,
    lookups: Object
  },
  data() {
    return {
      draftRounds: [
        { value: 1, text: 1 },
        { value: 2, text: 2 },
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
      pickTime: "",
      roundCount: 1,
      startTime: "",
      selected: "Manual",
      options: [
        { item: "Manual", name: "Manual" },
        { item: "Automatic", name: "Automatic", notEnabled: true }
      ],
      datetime: null
    };
  },
  methods: {
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
    },
    loadSettings(draftSettings) {
      // Finish setting properties here.
      this.draftName = draftSettings.name;
      this.isComputerTeams = draftSettings.isComputerTeams;
      this.isPublic = draftSettings.isPublic;
      this.roundCount = draftSettings.roundCount;
      this.pickTime = draftSettings.pickTime;
      this.startTime = draftSettings.startTime;
    }
  },
  computed: {
    showPassword() {
      if (this.draft) {
        return !this.draft.isPublic && this.isOwner && !this.isPublic;
      } else {
        return !this.isPublic;
      }
    }
  }
};
</script>

<style scoped>
#DraftSettings {
  display: block;
  position: fixed;
  right: 0;
  bottom: 0;
  top: 9%;
  background-color: rgb(255, 255, 255); 
  width:20%;
  height: 98%;
  text-align:left;
  padding:0%;
}

#draftSettingsArrowToggle {
  display: block;
}
#btnDraftMobileMenu {
  display: none;
}

#draftSettingsContent {
  padding-left: 50px;
  padding-top: 2%;
  padding-right: 4%;
  height: 100%;
}

.fullscreenIt {
  position: fixed;
  right: 0;
  width: 100%;
  height: 100%;
}

#draftSettingsContentForm {
  margin-bottom: 50%;
}

@media only screen and (max-width: 600px) {
  #DraftSettings {
    display: none;
  }
  #draftSettingsArrowToggle {
    display: none;
  }
  #btnDraftMobileMenu {
    position: fixed;
    right: 1%;
    top: 6%;
    display: block;
    z-index: 99;
    /* background-color: aliceblue; */
    color: white;
  }
}
</style>
