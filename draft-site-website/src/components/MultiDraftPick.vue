<template>
   <div class="DraftPre" style="width:100%;height:100%;overflow: hidden;">
      <div class="grid-container" style="width:100%;height:100%;">
         <div class="TeamPickingArea">
            <!-- Starting arrow -->
            <img alt="Vue logo" src="../assets/arrow2.png" style="">
            <!-- ITEMS -->
            <div class="primaryTri">Team 1<img alt="Vue logo" src="../assets/arrow.png" style=""></div>
            <div class="secondaryTri">Team 2<img alt="Vue logo" src="../assets/arrow2.png" style=""></div>
            <div class="primaryTri">Team 1<img alt="Vue logo" src="../assets/arrow.png" style=""></div>
            <div class="secondaryTri">Team 2<img alt="Vue logo" src="../assets/arrow2.png" style=""></div>
            <div class="primaryTri">Team 1<img alt="Vue logo" src="../assets/arrow.png" style=""></div>
            <div class="secondaryTri">Team 2<img alt="Vue logo" src="../assets/arrow2.png" style=""></div>
            <div class="primaryTri">Team 1<img alt="Vue logo" src="../assets/arrow.png" style=""></div>
            <div class="secondaryTri">Team 2<img alt="Vue logo" src="../assets/arrow2.png" style=""></div>
            <div class="primaryTri">Team 1<img alt="Vue logo" src="../assets/arrow.png" style=""></div>
            <div class="secondaryTri">Team 2<img alt="Vue logo" src="../assets/arrow2.png" style=""></div>
            <div class="primaryTri">Team 1<img alt="Vue logo" src="../assets/arrow.png" style=""></div>
            <div class="secondaryTri">Team 2<img alt="Vue logo" src="../assets/arrow2.png" style=""></div>
            <div class="primaryTri">Team 1<img alt="Vue logo" src="../assets/arrow.png" style=""></div>
            <div class="secondaryTri">Team 2<img alt="Vue logo" src="../assets/arrow2.png" style=""></div>
            <div class="primaryTri">Team 1<img alt="Vue logo" src="../assets/arrow.png" style=""></div>
         </div>
         <div class="MainArea">
            <div class="RolesToFillArea">
               <h6 style="padding-top: 10px;">Roles to fill</h6>
            </div>
            <div class="AvailablePlayersArea">

               <MultiDraftPickItems />
               <MultiDraftPickItems />
               <MultiDraftPickItems />
               <MultiDraftPickItems />
               <MultiDraftPickItems />
               <MultiDraftPickItems />
               <MultiDraftPickItems />
               <MultiDraftPickItems />
               <MultiDraftPickItems />
               <MultiDraftPickItems />
               <MultiDraftPickItems />
               <MultiDraftPickItems />
               <MultiDraftPickItems />
               <MultiDraftPickItems />
               <MultiDraftPickItems />
               <MultiDraftPickItems />

            </div>
         </div>
      </div>
   </div>
</template>
<script>
import MultiDraftPickItems from "./MultiDraftPickItems.vue";

export default {
    components: {
        MultiDraftPickItems
    }
}



</script>
<style scoped>
.grid-container {
  display: grid;
  grid-template-columns: 100%;
  grid-template-rows: 14% 86%;
  grid-template-areas: "TeamPickingArea" "MainArea";
}

.TeamPickingArea { 
    grid-area: TeamPickingArea; 
    background-color: rgb(255, 255, 255);
    text-align: left;
    overflow-x: auto;
    display: inline-block;
}
.TeamPickingArea img {
    height:100%;
}
.TeamPickingArea div {
    display: inline-block;
    height:100%;
}
.primaryTri {
    background-color: #1E252D;
    color: white;
    padding-left: 10px;
}
.secondaryTri {
    background-color: white;
    color: #1E252D;
    padding-left: 10px;
}

.MainArea {
  display: grid;
  grid-template-columns: 10% 90%;
  grid-template-rows: 100%;
  grid-template-areas: "RolesToFillArea AvailablePlayersArea";
  grid-area: MainArea;
}

.RolesToFillArea { 
    grid-area: RolesToFillArea; 
    background-color: rgb(255, 255, 255);
}

.AvailablePlayersArea { 
    grid-area: AvailablePlayersArea; 
    background-color: #1E252D;

    background-image: url("../assets/bg.jpg");
    background-repeat: no-repeat;
    background-size: cover;
    overflow-y: auto;

    padding: 25px;
}


</style>