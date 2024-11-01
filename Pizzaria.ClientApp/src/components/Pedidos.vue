<template>
  <div style="display: inline">
    <br />
    <div id="headerActions">
      <router-link to="/novopedido" class="menu-text" style="float: right">
        <span>Novo pedido</span>
      </router-link>
    </div>
    <div class="main-container" v-for="pedido in pedidos">
      <card-pedidos :idPedido="pedido.IdPedido" :dataPedido="pedido.DataPedido" :status="pedido.StatusPedido"
        :precoPedido="pedido.ValorPedido" :tipoPedido="pedido.tipoPedido""></card-pedidos>
    </div>
  </div>
</template>

<script>
import { mapGetters, mapActions } from "vuex";
import CardPedidos from "./partial/card-pedidos.vue";
export default {
  data() {
    return {
      pedidos: []


    }
  },
  methods: {
    ...mapActions("pedidos", ['requestPedidos'])


  },
  async mounted() {

    this.pedidos = await this.requestPedidos();
  },
  components: {
    CardPedidos,
  },
  computed: {



  }
};
</script>

<style></style>