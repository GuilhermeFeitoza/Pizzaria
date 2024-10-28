<template>
  <div class="main-container">
    <h1>Novo Pedido</h1>
    <div>
      <span @click="changeMenu('pizza')" style="cursor: pointer"><img class="img-submenu"
          src="./../assets/icons/pizza.png" />Pizzas</span>
      <span @click="changeMenu('bebida')" style="cursor: pointer"><img class="img-submenu"
          src="./../assets/icons/refrigerante.png" />Bebidas</span>
    </div>

    <span class="order-price">Total do Pedido : <b>R${{ formatPrice(this.getTotalPedido) }}</b></span>
    <br />
    <br />
    <br />
    <h2 v-if="isPizza">Pizzas</h2>
    <div class="div-produtos" v-if="isPizza">
      <Card-pizza-carrinho v-for="pizza in pizzas" v-bind:key="pizza.IdPizza" :idProduto="pizza.IdPizza" :nomeProduto="pizza.Nome"
        :valorProduto="pizza.Preco" :img="'noimage.png'"></Card-pizza-carrinho>
    </div>

    <h2 v-if="isBebida">Bebidas</h2>
    <div v-if="isBebida" class="div-produtos">
      <Card-pizza-carrinho v-for="bebida in bebidas" v-bind:key="bebida.IdBebida" :nomeProduto="bebida.Nome"
        :valorProduto="bebida.Preco" :img="'bebida.jpg'"></Card-pizza-carrinho>
    </div>
    <br />
    <br />
    <br />
    <br />
    <div class="button-container bottom-buttons">
      <button class="buttonConfirm" style="width: 50%" @click="toggleModalResumo">Confirmar Pedido</button>
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
      isBebida: false,
      isPizza: true,
      pizzas: [],
      bebidas: [],
    };
  },
  components: {
    CardPizzaCarrinho,
  },
  beforeDestroy() {
    this.clearPedido();
  },
  async mounted() {

    this.pizzas = await this.requestPizzas();
    this.bebidas = await this.requestBebidas();
    console.log(bebidas);
    

  },
  methods: {
    ...mapActions("modal", ["toggleModalResumo"]),
    ...mapActions("pizzas", ["requestPizzas"]),
    ...mapActions("bebidas", ["requestBebidas"]),
    ...mapActions("novoPedido",["clearPedido"]),
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
    ...mapGetters("novoPedido", ["getTotalPedido"]),

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

.bottom-buttons {
  justify-content: space-around;
  display: flex;
  position: fixed;
  width: 100%;
  bottom: 0;
  padding-top: 10vh;
}

.img-submenu {
  width: 40px;
  height: 40px;
  position: relative;
  top: 10px;
}

.div-produtos {
  display: inline-flex;
  max-width: 80%;
  flex-wrap: wrap;
}
</style>