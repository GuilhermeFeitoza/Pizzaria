<template>
  <div>
    <h1>Novo Pedido</h1>
    <span class="order-price">Total do Pedido : <b>R${{ formatPrice(this.getValorPedido)}}</b></span>
    <br>
    <br>
    <br>
    <div style="display: inline-flex; max-width: 80%; flex-wrap: wrap">
      <Card-pizza-carrinho></Card-pizza-carrinho>
      <Card-pizza-carrinho></Card-pizza-carrinho>
    </div>
  </div>
</template>
<script>
import { mapActions, mapGetters } from "vuex";
import CardPizzaCarrinho from "./partial/card-pizza-carrinho.vue";
export default {
  data() {
    return {
      valorPedido: 0.0,
    };
  },
  components: {
    CardPizzaCarrinho,
  },
  methods: {
    formatPrice(value) {
        let val = (value/1).toFixed(2).replace('.', ',')
        return val.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ".")
    }



  },
  computed: {
    getValorPedido() {
      return this.valorPedido;
    },
  },
};
</script>
<style scoped>
.order-price {
  font-size: 42px;
  float: right;
}
</style>