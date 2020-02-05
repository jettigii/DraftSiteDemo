<template>
   <div class="DraftCreate">
      <div id="main">
         <!-- Post -->
         <section class="post">
            <header class="">

               <h2>Create Draft</h2>

               <form method="post" action="#">
                  <div class="row gtr-uniform">
                     <!-- Name -->
                     <div class="col-6 col-12-xsmall">
                        <input type="text" name="txtName" id="txtName" value="" placeholder="Name" />
                     </div>
                     <!-- Pick Time -->
                     <div class="col-3 col-12-xsmall">
                        <select name="ddTimePick" id="ddTimePick">
                           <option value="">- Pick Time -</option>
                           <option value="1">Time 1</option>
                           <option value="1">Time 2</option>
                           <option value="1">Time 3</option>
                           <option value="1">Time 4</option>
                        </select>
                     </div>
                     <!-- # of rounds -->
                     <div class="col-3 col-12-xsmall">
                        <select name="ddRounds" id="ddRounds">
                           <option value="">- # of Rounds -</option>
                           <option value="1">1</option>
                           <option value="1">2</option>
                           <option value="1">3</option>
                           <option value="1">4</option>
                        </select>
                     </div>
                     <div class="grid-container row gtr-uniform">
                        <!-- Public -->
                        <div class="Public">
                           <h3>Public</h3>
                        </div>
                        <!-- rdPublic -->
                        <div class="rdPublic">
                           <div class="col-4 col-12-small" style="float:left;width:50%;">
                              <input type="radio" id="rdoPublicYes" name="rdoPublic" >
                              <label for="rdoPublicYes">Yes</label>
                           </div>
                           <div class="col-4 col-12-small">
                              <input type="radio" id="rdoPublicNo" name="rdoPublic" checked>
                              <label for="rdoPublicNo">No</label>
                           </div>
                        </div>
                        <!-- comTeams -->
                        <div class="comTeams">
                           <h3>Allow Computer Teams</h3>
                        </div>
                        <!-- rdComTeams -->
                        <div class="rdComTeams">
                           <div class="col-4 col-12-small" style="float:left;width:50%;">
                              <input type="radio" id="rdoCOMTeamsYes" name="rdoCOMTeams" checked>
                              <label for="rdoCOMTeamsYes">Yes</label>
                           </div>
                           <div class="col-4 col-12-small">
                              <input type="radio" id="rdoCOMTeamsNo" name="rdoCOMTeams">
                              <label for="rdoCOMTeamsNo">No</label>
                           </div>
                        </div>
                        <!-- draftStart -->
                        <div class="draftStart">
                           <h3>Draft Start</h3>
                        </div>
                        <!-- rdDraftStart -->
                        <div class="rdDraftStart">
                           <div class="col-4 col-6-small" style="float:left;width:50%;">
                              <input type="radio" id="rdoDraftStartAuto" name="rdoDraftStart" onclick="startDateSwitch();" checked>
                              <label for="rdoDraftStartAuto">Automatic</label>
                           </div>
                           <div class="col-4 col-6-small">
                              <input type="radio" id="rdoDraftStartMan" name="rdoDraftStart" onclick="startDateSwitch();">
                              <label for="rdoDraftStartMan">Manual</label>
                           </div>
                           <!-- Manual Date -->
                           <h3 id="lblManDate" style="display: none;">Select start date:</h3>
                           <div class="col-6 col-12-xsmall">
                              <input type="date" name="tpManualDate" id="tpManualDate" value="" placeholder="CurrentDate" style="display: none;"/>
                           </div>
                        </div>
                     </div>
                     <!-- Manual Date -->
                     <h3 id="lblManDate" style="display: none;">Select start date:</h3>
                     <div class="col-6 col-12-xsmall">
                        <input type="date" name="tpManualDate" id="tpManualDate" value="" placeholder="CurrentDate" style="display: none;"/>
                     </div>
                     <!-- Submit and reset Buttons -->
                     <div class="col-12">
                        <ul class="actions">
                           <li><input type="submit" value="Create" class="primary" /></li>
                           <li><input type="reset" value="Reset" /></li>
                        </ul>
                     </div>
                  </div>
               </form>

            </header>
         </section>
      </div>
   </div>
</template>

<style scoped>

.grid-container {
  display: grid;
  grid-template-columns: 50% 50%;
  grid-template-rows: 33% 33% 33%;
  grid-template-areas: "Public rdPublic" "comTeams rdComTeams" "draftStart rdDraftStart";
  width:100%;
  text-align: left;
}

.Public { grid-area: Public; }

.rdPublic { grid-area: rdPublic; }

.comTeams { grid-area: comTeams; }

.rdComTeams { grid-area: rdComTeams; }

.draftStart { grid-area: draftStart; }

.rdDraftStart { grid-area: rdDraftStart; }


</style>