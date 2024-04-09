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
      >Total do Pedido : <b>R${{ formatPrice(this.getTotalPedido) }}</b></span
    >
    <br />
    <br />
    <br />
    <h2 v-if="isPizza">Pizzas</h2>
    <div class="div-produtos" v-if="isPizza">
      <Card-pizza-carrinho
        v-for="item in pizzas"
        v-bind:key="item.id"
        :nomeProduto="item.nome"
        :valorProduto="item.preco"
        :img="item.img"
      ></Card-pizza-carrinho>
    </div>

    <h2 v-if="isBebida">Bebidas</h2>
    <div v-if="isBebida" class="div-produtos">
      <Card-pizza-carrinho
        v-for="bebida in bebidas"
        v-bind:key="bebida.id"
        :nomeProduto="bebida.nome"
        :valorProduto="bebida.preco"
        :img="bebida.img"
      ></Card-pizza-carrinho>
    </div>
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
      pizzas: [
        { id:1,img: "frangoc.jpg", nome: "Pizza de frango com catupiry", preco: 35.0,},
        { id:2,img: "calabresa.jpg", nome: "Pizza de calabresa", preco: 35.0 },
        { id:3,img: "portuguesa.jpg", nome: "Pizza de manjericao", preco: 40.0 },
        { id:4,img: "peperoni.jpg", nome: "Pizza de peperoni", preco: 35.0 },
      ],
      bebidas: [
        { id: 10, img: "bebida.jpg", nome: "Coca-Cola", preco: 10.0 },
        { id: 12, img: "bebida.jpg", nome: "Coca-Cola", preco: 10.0 },
        { id: 13, img: "bebida.jpg", nome: "Guaraná", preco: 10.0 },
        { id: 14, img: "bebida.jpg", nome: "Pepsi", preco: 10.0 },
        { id: 15, img: "bebida.jpg", nome: "Dolly", preco: 10.0 },
      ],
    };
  },
  components: {
    CardPizzaCarrinho,
  },

  methods: {
     ...mapActions("modal", ["toggleModalResumo"]),
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