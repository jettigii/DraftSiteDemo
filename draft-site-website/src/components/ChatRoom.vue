<template>
  <!-- CHAT -->
  <div id="chatMenu" class="box">
    <button
      id="open-button"
      class="open-button button fit small primary"
      onclick="openForm()"
    >
      Group Chat <i class="fas fa-angle-up"></i>
    </button>
    <div class="chat-popup" id="chatForm">
      <h5>Group Chat</h5>

      <div style="overflow: auto;max-height: 420px;"></div>
      <!-- Messages go here -->
      <ChatBubble
        v-for="item in messages"
        :key="item.id"
        :messageUsername="item.username"
        :message="item.message"
      />
      <div style="background-color:white;height:40px;margin:5px;width:100%;">
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
      this.$emit("send-message", this.message);
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
