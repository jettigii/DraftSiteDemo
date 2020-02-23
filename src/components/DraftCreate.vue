<template>
  <div class="DraftCreate blur" style="width:100%;height:100%">
    <div id="main" style="background-color: rgba(0, 0, 0, 0); width:100%">
      
      <div class="centerIt">
        <div class="modal-content">
          <div class="modal-header">
            <h4 class="modal-title">Create Draft</h4>
            <router-link to="/"><button type="button" class="close" data-dismiss="modal" style="border: 0;border-radius: 0px;box-shadow: none; background: none;">&times;</button></router-link>
          </div>
          
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
          pattern="[A-Za-z0-9]{3,24}"
          title="Must be 3 to 24 characters and contain only letters and numbers only, no punctuation or special characters"
          required
        ></b-form-input>
        </div>
        <br>
        <div class="actions" style="display:inline-block; text-align:left; width:40%;">
        <label for="draftRoundSelected">Draft Rounds</label>
        <b-form-select
          required
          v-model="draftRoundSelected"
          :options="draftRounds"
          id="draftRoundSelected"
        ></b-form-select>
        </div>
        
        <!-- Spacer -->
        <div style="display:inline-block; text-align:left; width:5%;"></div>

        <div class="actions" style="display:inline-block; text-align:left; width:40%;">
        <label for="draftRoundSelected">Draft Time</label>
        <b-form-select
          required
          v-model="draftTimeSelected"
          :options="draftLookups.draftTimes"
          value-field="timeInSeconds"
          text-field="value"
        ></b-form-select>
        </div>

        <br><br>

        <b-form-checkbox v-model="isPublic" name="is-public-check-button" switch size="sm"
          ><label>Public?</label>
        </b-form-checkbox>

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

        <div class="actions" style="display:inline-block; margin-right:10px; text-align:left;">
        <label>Draft Start</label>
        </div>

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
        <h5 id="lblManDate" style="display: none;">
          Select start date:
        </h5>
        <input
          type="date"
          name="tpManualDate"
          id="tpManualDate"
          value=""
          placeholder="CurrentDate"
          style="display: none;"
        />
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
      draftName: ""
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

.blur {
  background-image: url('../assets/bg.jpg');
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
