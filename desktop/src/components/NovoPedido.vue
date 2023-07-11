<template>
  <div>
    <h1>Novo Pedido</h1>
    <div>
      <span @click="changeMenu('pizza')" style="cursor: pointer"
        ><img
          class="img-submenu"
          src="./../assets/icons/pizza.png"
        />Pizzas</span
      >
      <span @click="changeMenu('bebida')" style="cursor: pointer"
        ><img
          class="img-submenu"
          src="./../assets/icons/refrigerante.png"
        />Bebidas</span
      >
    </div>

    <span class="order-price"
      >Total do Pedido : <b>R${{ formatPrice(this.getValorPedido) }}</b></span
    >
    <br />
    <br />
    <br />
    <div
      v-if="isPizza"
      style="display: inline-flex; max-width: 80%; flex-wrap: wrap"
    >
      <Card-pizza-carrinho></Card-pizza-carrinho>
      <Card-pizza-carrinho></Card-pizza-carrinho>
    </div>

    <div
      v-if="isBebida"
      style="display: inline-flex; max-width: 80%; flex-wrap: wrap"
    >
      <Card-pizza-carrinho :bebida = 'true'></Card-pizza-carrinho>
      <Card-pizza-carrinho :bebida = 'true'></Card-pizza-carrinho>
    </div>
    <div
      class="button-container"
      style="
        justify-content: space-around;
        display: flex;
        float: bottom;
        position: fixed;
        width: 100%;
        bottom: 0;
      "
    >
      <button class="buttonConfirm" style="width: 50%">Confirmar Pedido</button>
      <button style="width: 50%" class="buttonExit">Cancelar Pedido</button>
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
      isBebida:false,
      isPizza:true,
    };
  },
  components: {
    CardPizzaCarrinho,
  },
  methods: {
    formatPrice(value) {
      let val = (value / 1).toFixed(2).replace(".", ",");
      return val.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ".");
    },
    changeMenu(menu) {
      if (menu === "pizza") {
        this.isPizza = true;
        this.isBebida = false; 
      }
      if (menu === "bebida") {
        this.isBebida = true;
        this.isPizza = false;
      }
    },
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
.img-submenu {
  width: 40px;
  height: 40px;
  position: relative;
  top: 10px;
}
</style>