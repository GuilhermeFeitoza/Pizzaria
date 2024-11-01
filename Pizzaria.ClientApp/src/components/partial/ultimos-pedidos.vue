<template>

  <div>
    <h1 style="font-family: Calibri">Últimos pedidos</h1>
    <div class="pedido-container" v-for="pedido in ultimosPedidos">
      <card-pedidos :idPedido="pedido.IdPedido" :dataPedido="pedido.DataPedido" :status="pedido.StatusPedido"
        :precoPedido="pedido.ValorPedido" :tipoPedido="pedido.tipoPedido""></card-pedidos>
    </div>

  </div>

</template>

<script>
import { mapActions } from 'vuex';
import CardPedidos from './card-pedidos.vue';
export default {
  data() {
    return {

      ultimosPedidos: []

    }

  },
  computed: {




  },
  components: {
    CardPedidos



  }, methods: {
    ...mapActions("pedidos", ["requestUltimosPedidos"]),


  }, async mounted() {


    this.ultimosPedidos = await this.requestUltimosPedidos(10);
  }


}

</script>

<style>
.pedido-container {
  display: flex;
  /* Ativa o Flexbox */
  flex-wrap: wrap;
  /* Permite que os cards se movam para a linha seguinte se não houver espaço suficiente */
  gap: 10px;
  /* Espaçamento entre os cards */
}
</style>