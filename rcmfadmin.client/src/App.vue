<template>
  <!-- <header>
    <Navbar />
  </header> -->



  <main class="bg-light container-fluid">

<div class="row">
  <div class="col-md-2 bg-dark lighten-10">
<AdminNavigator/>
  </div>
  <div class="col-md-10">
    <router-view />

  </div>
</div>

  </main>
   <!-- <footer class="bg-dark text-light">
    Made by Molè
  </footer> -->
</template>

<script>
import { computed } from 'vue'
import { AppState } from './AppState'
import AdminNavigator from "./components/AdminNavigator.vue"
import Navbar from './components/Navbar.vue'

export default {
  setup() {
    return {
      appState: computed(() => AppState)
    }
  },
  components: { Navbar, AdminNavigator }
}
</script>
<style lang="scss">
@import "./assets/scss/main.scss";

:root{
  --main-height: calc(100vh - 32px - 64px);
}


footer {
  display: grid;
  place-content: center;
  height: 32px;
}
</style>
