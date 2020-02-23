<template >
   <div class="DraftPre" style="width:100%;height:100%;overflow: hidden;">
      <div id="main" style="width:100%;height:100%;">

         <div id="preGrid" class="grid-container" style="width:100%;height:100%;padding:0px;">
            <div class="mainArea">
                <!-- MAIN SWITCHING AREA -->
               <div class="teamPlayersArea" style="border-width: 0px 2px 0px 2px;border-style: solid;border-color:#949494;">
                   <!-- TEAMS -->
                   <div id="teamArea" style="display:block;background-color:#F5F5F5;height:100%;overflow: auto;">TEAMS</div>
                   <!-- PLAYERS -->
                   <div id="playersArea" style="display:none;background-color:#F5F5F5;height:100%;overflow: auto;">PLAYERS</div>
               </div>
               <!-- TOP SWITCHING BUTTONS -->
               <div class="teamPlayersLabelArea" style="width:100%;height:100%;padding:0px;border-width: 2px 2px 2px 2px;border-style: solid;border-color:#212931;">
                  <div class="teamLabelArea" style=""><a href="#" class="button fit " onclick="teamSwitch()" id="btnTeamSwitch">Teams</a></div>
                  <div class="playerLabelArea"><a href="#" class="button fit primary" onclick="playerSwitch()" id="btnPlayerSwitch">Players</a></div>
               </div>
            </div>
            <!-- DRAFT SETTINGS -->
            <div class="draftSettings" id="draftSettings" style="width:100%;height:100%;border-width: 2px 0px 0px 0px;border-style: solid;border-color:#212931;">
                
                <div id="draftSettingsArrowToggle" style="height:100%;width:8%;float:left;background-color:#7E94A9;">
                  <button class="" style="height:100%;width:100%;color:white;border:none;background:none;padding:0;" onclick="draftSettingsSwitch()" id="btnSettingsToggle">
                    <i style="height:100%;width:100%;margin: 0;top: 50%;color:white;" id="draftSettingsArrow" class="fas fa-angle-right"></i>
                  </button>
                </div>

                <div style="float:right;width:80%;height:40px;">
                  <h4 class="modal-title" style="text-align:left;padding-top:10px;">Draft Settings</h4>
                  <br>
                  <button id="btnStartDraft" class="button primary" style="width:18.4%;position:absolute;bottom:0px;right:0px;">Start Draft</button>
                </div>
            </div>
         </div>
         <!-- CHAT -->
         <div id="chatMenu" class="box">
         <button id="open-button" class="open-button button fit small primary" onclick="openForm()">Group Chat <i class="fas fa-angle-up"></i></button>
         <div class="chat-popup" id="chatForm">
               <form action="#" class="form-container">
                 
               <h5>Group Chat</h5>
               
               <div style="overflow: auto;max-height: 420px;">
                 <!-- MESSAGE EXAMPLE -->
               <div class="containerMessage darker">
                 <img src="https://picsum.photos/255/255" alt="Avatar" class="right" style="width:100%;">
                 <p>{{ message }}</p>
                 <span class="user-left">{{ messageUsername }}</span>
               </div>
               <!-- MESSAGE EXAMPLE -->

               <div class="containerMessage">
                 <img src="https://picsum.photos/255/255" alt="Avatar" style="width:100%;">
                 <p>Did you know the first French fries weren't actually cooked in France?</p>
                 <span class="user-right">{{ messageUsername }}</span>
               </div>

               <div class="containerMessage darker">
                 <img src="https://picsum.photos/255/255" alt="Avatar" class="right" style="width:100%;">
                 <p>O Rly?</p>
                 <span class="user-left">{{ messageUsername }}</span>
               </div>

               <div class="containerMessage">
                 <img src="https://picsum.photos/255/255" alt="Avatar" style="width:100%;">
                 <p>Yea, they were cooked in Greece.</p>
                 <span class="user-right">{{ messageUsername }}</span>
               </div>

               <div class="containerMessage darker">
                 <img src="https://picsum.photos/255/255" alt="Avatar" class="right" style="width:100%;">
                 <p>lol, hilarous dad!</p>
                 <span class="user-left">{{ messageUsername }}</span>
               </div>
               </div>

               <div style="background-color:white;height:40px;margin:5px;width:100%;">
                  <input type="text" id="msg" name="msg" placeholder="Type a message.." style="float:left;width:80%;height:40px;background-color:white;">
                  <button type="submit" class="btn" style="float:right;width:20%;height:40px;"><i class="fas fa-paper-plane"></i></button>
               </div>

            </form>
         </div>
         </div>

      </div>
   </div>
</template>

<script>
import { mapActions, mapState } from "vuex";

export default {
  async mounted() {
    await this.loadDraftLobby();
  },
  props: {
    messageUsername: String,
    message: String
  },
  methods: {
    ...mapActions({
      loadDraftLobby: "draft/loadDraftLobby"
    })
  },
  computed: {
    ...mapState({
      username: state => state.user.username
    }),
    isOwner: function() {
      return this.username == this.messageUsername;
    }
  }
};
</script>

<style scoped>

/* GRID LAYOUT */
.grid-container {
  display: grid;
  grid-template-columns: 80% 20%;
  grid-template-rows: 100%;
  grid-template-areas: "mainArea draftSettings";
}

.mainArea {
  display: grid;
  grid-template-columns: 100%;
  grid-template-rows: 8% 92%;
  grid-template-areas: "teamPlayersLabelArea" "teamPlayersArea";
  grid-area: mainArea;
}

.teamPlayersArea { grid-area: teamPlayersArea; }

.teamPlayersLabelArea {
  display: grid;
  grid-template-columns: 50% 50%;
  grid-template-rows: 100%;
  grid-template-areas: "teamLabelArea playerLabelArea";
  grid-area: teamPlayersLabelArea;
}

.teamLabelArea { grid-area: teamLabelArea; }

.playerLabelArea { grid-area: playerLabelArea; }

.draftSettings { grid-area: draftSettings; }


/* CHAT WINDOW */
/* The popup chat - hidden by default */
.chat-popup {
   width: 280px;
   display: none;
  position: fixed;
  bottom: 48px;
  right: 22%;
  /* margin-bottom: 0px; */
  z-index: 1;
}

.open-button {
  /* padding: 16px 20px; */
  border: none;
  cursor: pointer;
  position: fixed;
  bottom: 0%;
  right: 22%;
  width: 280px;
  height: 48px;
  z-index: 99;
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