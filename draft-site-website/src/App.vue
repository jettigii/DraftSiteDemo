<template>
  <div id="app">
    <!-- <img alt="Vue logo" src="./assets/logo.png"> -->

    <!-- Nav -->
    <nav id="nav">
      <ul class="links">
        <li class="active"><router-link to="home">Draft Logo</router-link></li>

        <li><router-link to="lobby">Draft Lobby</router-link></li>
        <li><router-link to="createDraft">Create Draft</router-link></li>
      </ul>
      {{ user.username }}
    </nav>

    <div style="width:100%; height:100%; padding-top: 100px;">
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
  margin: 0px;
  /* margin-top: 100px; */
  height: 100%;
  width: 100%;
}
#nav {
  border-bottom-width: 5px;
  /* border-color: goldenrod; */
  border-color: red;
  border-style: solid;
}
</style>
