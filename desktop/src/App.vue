<template>
  <div id="app">
  <login v-if = "!getIsLogado"></login>
  <div  v-if="getIsLogado">
    <header>
      <NavBar />
      <MenuBar />
    </header>
    <br />
    <br />
    <br />
    <br />
    <router-view />
    <Cliente-modal />
    <Funcionario-modal />
  </div>
  </div>
</template>
<script>
import NavBar from "./components/NavBar.vue";
import Home from "./components/Home.vue";
import ClienteModal from "./components/modal/Cliente-modal.vue";

import "../src/style.css";
import FuncionarioModal from "./components/modal/Funcionario-modal.vue";
import MenuBar from "./components/MenuBar.vue";
import Login from './components/login.vue';
import {mapGetters,mapActions} from 'vuex' 

export default {
  name: "App",
  computed:{
    ...mapGetters('login',['getIsLogado'])

  },

  components: {
    NavBar,
    Home,
    ClienteModal,
    FuncionarioModal,
    MenuBar,
    Login,
  },
};
</script>
