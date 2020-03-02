<template>
  <!-- CHAT -->
  <div id="chatMenu">
    <button
      id="open-button"
      class="open-button button fit small primary"
      onclick="openForm()"
    >
      Group Chat <i id="groupChatArrow" class="fas fa-angle-up"></i>
    </button>
    <div class="chat-popup" id="chatForm">
      <h5 >Group Chat</h5>

      <div id="messageArea">
        <!-- Messages go here -->
        <ChatBubble
          v-for="item in messages"
          :key="item.id"
          :messageUsername="item.username"
          :message="item.message"
        />
      </div>

      <div id="sendMessageArea">
        <input
          v-model="message"
          type="text"
          id="msg"
          name="msg"
          placeholder="Type a message.."
          style="float:left;width:80%;height:40px;background-color:white;"
          
        />
        <button
          class="btn"
          id="btnSendMessage"
          style="float:right;width:20%;height:40px;"
          @click="sendMessage()"
        >
          <i class="fas fa-paper-plane"></i>
        </button>
      </div>
    </div>
  </div>
</template>

<script>
import ChatBubble from "./ChatBubble.vue";

export default {
  props: {
    username: String
  },
  data() {
    return {
      message: "",
      messages: []
    };
  },
  components: {
    ChatBubble
  },
  methods: {
    receiveMessage(message) {
      this.messages.push(message);
    },
    sendMessage: async function() {
      //send message
      this.$emit("send-message", this.message);
      //clear string
      this.message = "";
      return false;
    }
  },
  computed: {
    isOwner: function() {
      return this.username == this.messageUsername;
    }
  }
};
</script>

<style scoped>
/* CHAT WINDOW */
/* The popup chat - hidden by default */
.chat-popup {
  width: 280px;
  display: none;
  position: fixed;
  bottom: 48px;
  right: 22%;
  max-height: 50%;
  overflow: hidden;
  /* margin-bottom: 0px; */
  z-index: 1;
  background-color:rgb(187, 184, 199);
}

.open-button {
  /* padding: 16px 20px; */
  border-width: 2px;
  border-style: solid;
  border-color: #212931;
  cursor: pointer;
  position: fixed;
  bottom: 0%;
  right: 22%;
  width: 280px;
  height: 48px;
  z-index: 99;
}

#messageArea {
  width: 100%;
  max-height: 500px;
  overflow-y: auto;
  padding-top: 5%;
  padding-bottom: 45%;
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

#sendMessageArea {
  position: fixed;
  bottom: 45px;
  width: 100%;
  background-color: white;
  height: 40px;
  margin: 5px;
  width: 280px;
  right: 21.7%;
  z-index: 50;
}

@media only screen and (max-width: 600px) {
  #chatMenu {
    width: 100%;
    height: 100%;
  }
  .chat-popup {
    width: 100%;
    height: 100%;
    overflow: hidden;
    display: none;
    position: fixed;
    bottom: 64px;
    right: 0;
    padding-top: 20%;
    max-height: 100%;
    /* margin-bottom: 0px; */
    z-index: 50;
    background-color: #212931;
  }

  .open-button {
    /* padding: 16px 20px; */
    border-width: 2px;
    border-style: solid;
    border-color: #212931;
    cursor: pointer;
    position: fixed;
    bottom: 0%;
    right: 0;
    width: 100%;
    height: 64px;
    z-index: 99;
  }

  #sendMessageArea {
    position: fixed;
    bottom: 60px;
    left: 0;
    width: 100%;
    background-color: white;
    height: 50px;
    margin: 5px;
    width: 100%;
    font-size: 26px;
  }

  #messageArea {
    width: 100%;
    max-height: 100%;
    overflow-y: auto;
    padding: 4%;
    padding-top: 5%;
    padding-bottom: 15%;
  }
}
</style>
