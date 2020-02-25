<template>
  <div>
                 <!-- MESSAGE EXAMPLE -->
               <div class="containerMessage">
                 
                 <p style="margin:0px;">
                   <span style="color:grey;font-size:16px;">{{ username }}:</span>
                   <span style="margin-left:5px;font-size:16px;">{{ message }}</span>
                 </p>
                 
               </div>
               <!-- MESSAGE EXAMPLE -->
  </div>
</template>

<script>
export default {
  props: {
    username: String,
    message: String
  }

}
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
  padding: 2px;
  padding-left: 8px;
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
