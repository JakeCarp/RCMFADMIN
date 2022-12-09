<template>
  <div class="container">
    <div class="row">
      <div class="col-md-12">
        <Login />
      </div>
    </div>
  </div>
</template>

<script>
import { computed,onMounted } from "vue";
import { AppState } from "../AppState";
import Login from "../components/Login.vue";
import { AuthService } from "../services/AuthService";

export default {
  setup() {
    onMounted(() => {
      // AuthUser();
    });
    async function AuthUser() {
  
    
        AuthService.loginWithRedirect();
      
   
    }
    return {
      user: computed(() => AppState.user),
      account: computed(() => AppState.account),
      async login() {
        AuthService.loginWithPopup();
      },
      async logout() {
        AuthService.logout({ returnTo: window.location.origin });
      },
    };
  },
  components: { Login },
};
</script>

<style lang="scss" scoped></style>
