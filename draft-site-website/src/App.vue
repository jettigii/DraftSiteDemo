<template>
  <div id="app">
    <!-- <img alt="Vue logo" src="./assets/logo.png"> -->

    <!-- Nav -->
    <nav id="nav">
      <ul class="links">
        <li class="active"><a href="index.html">Draft Logo</a></li>

        <router-link to="/">Draft Lobby</router-link>
        <router-link to="createDraft">Create Draft</router-link>
      </ul>
      {{ user.username }}
    </nav>

    <div>
      <router-view />
    </div>

    <!-- Copyright -->
    <div id="copyright">
      <ul>
        <li>&copy; 2020</li>
        <li>Designed by: FiniTech Inc.</li>
      </ul>
    </div>
  </div>
</template>

<script>
import { mapActions, mapState } from "vuex";

export default {
  name: "app",
  data() {
    return {
      user: {}
    };
  },
  async mounted() {
    await this.authenticate("abc");
    this.user = this.userData;
  },
  methods: {
    ...mapActions({
      authenticate: "user/authenticate"
    })
  },
  computed: {
    ...mapState({
      userData: state => state.user.user
    })
  }
};
</script>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 100px;
  height: 100%;
  width: 100%;
}
</style>
