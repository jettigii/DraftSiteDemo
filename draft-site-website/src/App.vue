<template>
  <div id="app">
    <!-- <img alt="Vue logo" src="./assets/logo.png"> -->

    <!-- Nav -->
					<nav id="nav" >
            
						<ul class="links">
							<li class="active"><a href="index.html">Draft Logo</a></li>
							<li ><a href="#Lobby">Lobby</a></li>
							<li ><a href="#Create">Create +</a></li>
						</ul>
						<ul class="icons">
							<li><a href="#" class="icon brands fa-twitter"><span class="label">Twitter</span></a></li>
							<li><a href="#" class="icon brands fa-facebook-f"><span class="label">Facebook</span></a></li>
							<li><a href="#" class="icon brands fa-instagram"><span class="label">Instagram</span></a></li>
							<li><a href="#" class="icon brands fa-github"><span class="label">GitHub</span></a></li>
						</ul>
					</nav>

    <HelloWorld msg="Welcome"/>
    
				<!-- Copyright -->
					<div id="copyright">
						<ul><li>&copy; 2020</li><li>Designed by: Finite Reality Tech Co.</li></ul>
					</div>

  </div>
</template>

<script>
// import HelloWorld from './components/Home.vue'
// import HelloWorld from './components/DraftLobby.vue'
import HelloWorld from './components/DraftCreate.vue'

export default {
  name: 'app',
  components: {
    HelloWorld
  }
}
</script>

<style>


#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 100px;
  height: 100%;width: 100%;
}
</style>
