<template>
  <div id="myModal" class="modal" v-if="getResumoModalOpen">
    <!-- Modal content -->
    <div class="modal-content">
      <h1>Resumo do pedido</h1>
      <div v-for="item in this.getItensPedido" v-bind:key="item.id">
        <span> 1 x {{item.nome}}</span> <br /><br />
      </div>

      <span class="close" v-on:click="toggleModalResumo">&times;</span>
      <div>
        <div class="buttonContainer">
          <button class="buttonConfirm" @click="createPedidoClick">
            Confirmar
          </button>
          <button
            class="buttonExit"
            @click="toggleModalResumo"
            style="padding-left: 20px"
          >
            Sair
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { mapActions, mapGetters } from "vuex";

export default {
  methods: {
    ...mapActions("modal", ["toggleModalResumo"]),
    ...mapActions("novoPedido", ["createPedido"]),
    async createPedidoClick(){
      let payload = {
        StatusPedido:0,
        TipoPedido: 'R',
        DataPedido:null,
        FormaPagamentoPedido: 'Cartão crédito',
        Endereco: null,
        ValorPedido: this.getTotalPedido,
        ItensPedidos: this.getItensPedido

      }
      await this.createPedido(payload);
      this.toggleModalResumo();

    }
  },
  computed: {
    ...mapGetters("modal", ["getResumoModalOpen"]),
    ...mapGetters("novoPedido", ["getItensPedido","getTotalPedido"]),
  },
};
</script>

<style>
</style>