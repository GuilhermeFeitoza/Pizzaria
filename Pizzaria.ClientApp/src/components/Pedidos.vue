<template>
  <div style="display: inline">
    <br />
    <div id="headerActions">
      <router-link to="/novopedido" class="menu-text" style="float: right">
        <span>Novo pedido</span>
      </router-link>
    </div>
    <div class="main-container" v-for="pedido in pedidos">
      <card-pedidos :dataPedido="'Segunda-Feira,21 de dezembro de 2022 20:05'" :status="'E'" :precoPedido="'33,00'"
        :tipoPedido="'RETIRADA'"></card-pedidos>
    </div>
  </div>
</template>

<script>
import { mapGetters } from "vuex";
import CardPedidos from "./partial/card-pedidos.vue";
export default {
  components: {
    CardPedidos,
  },
  computed: {

    data() {
      return {
        pedidos : []


      }
    }

  }
};
</script>

<style></style>