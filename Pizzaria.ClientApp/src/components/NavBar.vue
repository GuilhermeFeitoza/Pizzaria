<template>
  <div class="menu">
    <router-link to="/home"> </router-link>

    <div id="welcome">
      <router-link id="sair" to="/login">
        <span style="color: white;">Seja Bem vindo {{ nomeUsuario }}!!</span>
        <img src="../assets/exit.png" @click="logoutClick" />
      </router-link>
    </div>
  </div>
</template>

<script>
import { mapActions } from "vuex";
export default {
  name: "NavBar",
  data() {
    return {
      nomeUsuario: "Guilherme",
    };
  },
  methods: {
    ...mapActions("login", ["logout"]),
    logoutClick() {
      this.$router.push("/login");
      this.logout();
    },
  },
};
</script>
<style scoped>
#mySideBar {
  width: 15vw;
  margin-left: 15vw;
}

.menu {
  left: 0;
  background-color: #C70404;
  height: 3vw;
  width: 100vw;
  position: absolute;
  top: 0;

}
</style>
