<template>
  <div class="card-pedidos">
    <i v-show="this.status == 'P'" @click="cancelOrderClick" class="bi bi-x-circle"
      style="float: right; color: red;cursor: pointer;"></i>
    <span style="margin-left:0.5vw">
      {{ this.formatDate(this.dataPedido) }}
    </span>

    <br />
    <br />
    <span class="card-pedidos-status-text" style="">
      <img class="icon-size" :src="require(`@/assets/icons/${imgStatus}`)" />
      <span>{{ this.statusText }}</span>
      <span class="card-pedidos-type-text">
        {{ this.tipoPedido == "E" ? "ENTREGA" : "RETIRADA" }}
      </span>
    </span>
    <br />
    <span style="font-weight: bold; margin-left:0.5vw">
      {{ this.precoPedido.toLocaleString('pt-BR', {
        style: 'currency',
        currency: 'BRL'
      }) }}
      <p class="order-details">Detalhes do pedido</p>
    </span>
  </div>
</template>

<script>
import { mapActions } from 'vuex';
export default {
  props: {
    idPedido: Number,
    status: "E",
    dataPedido: "",
    precoPedido: "",
    tipoPedido: "",
  },
  data() {
    return {
      moreDetails: false,
    };
  },

  methods: {
    ...mapActions('pedidos', ['cancelOrder']),
    async cancelOrderClick() {

      await this.cancelOrder(this.idPedido);
      alert("Pedido cancelado")
    },
    formatDate(inputDate) {
      const date = new Date(inputDate);

      const options = {
        hour: '2-digit',
        minute: '2-digit',
        day: '2-digit',
        month: '2-digit',
        year: 'numeric'
      };

      return date.toLocaleString('pt-BR', options);
    },

  },
  computed: {

    statusText() {
      if (this.status == "P") {
        return "PREPARANDO"
      } else if (this.status == "C") {
        return "CANCELADO"
      } else if (this.status == "E") {
        return "ENTREGUE"

      }


    },
    imgStatus() {
      if (this.status == 1) {
        return "check.png";
      }
      else {
        return "check.png";
      }
    },
  },
};
</script>

<style>
.maisDetalhes {
  height: 27vw;
}

.card-pedidos {
  font-size: 1vw;
  max-width: 50%;
  width: 30%;
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
  border-radius: 0.3vw;
  margin-top: 1vw;
}

.order-details {

  font-size: 0.8vw;
  color: #ff6358;
  font-family: sans-serif;
  position: relative;
  left: 17vw;
  cursor: pointer;

}
</style>