<template>
  <div id="app">
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
</template>
<script>
import NavBar from "./components/NavBar.vue";
import Home from "./components/Home.vue";
import ClienteModal from "./components/modal/Cliente-modal.vue";

import "../src/style.css";
import FuncionarioModal from "./components/modal/Funcionario-modal.vue";
import MenuBar from "./components/MenuBar.vue";

export default {
  name: "App",
  components: {
    NavBar,
    Home,
    ClienteModal,
    FuncionarioModal,
    MenuBar,
  },
};
</script>
