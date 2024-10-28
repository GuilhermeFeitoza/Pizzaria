<template>
  <div>
    <login v-if="!getIsLogado"></login>
    <div v-if="getIsLogado">
      <header>
        <NavBar />
        <menu-side-bar></menu-side-bar>
      </header>
      <br />
      <br />
      <br />
      <br />
      <div style="margin-left:12%">
        <router-view />
        <Cliente-modal />
        <Funcionario-modal />
        <Pizza-modal />
        <ingrediente-modal />
        <Bebida-modal />
        <Resumo-pedido-modal></Resumo-pedido-modal>
      </div>
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
import Login from "./components/login.vue";
import { mapGetters, mapActions } from "vuex";
import MenuSideBar from "./components/MenuSideBar.vue";
import PizzaModal from './components/modal/Pizza-modal.vue';
import ResumoPedidoModal from './components/modal/Resumo-pedido-modal.vue';
import IngredienteModal from "./components/modal/Ingrediente-modal.vue";
import BebidaModal from "./components/modal/Bebida-modal.vue";

export default {
  name: "App",
  computed: {
    ...mapGetters("login", ["getIsLogado"]),
  },

  components: {
    NavBar,
    Home,
    ClienteModal,
    FuncionarioModal,
    MenuBar,
    Login,
    MenuSideBar,
    PizzaModal,
    ResumoPedidoModal,
    IngredienteModal,
    BebidaModal
  },
};
</script>
