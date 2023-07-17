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
    <h2
        v-if="isPizza"
     > Pizzas</h2>
    <div
      style="display: inline-flex; max-width: 80%; flex-wrap: wrap"
      v-if="isPizza"
     
    >
    
      <Card-pizza-carrinho
       v-for="item in pizzas"
      :key="item.id"
        :nomeProduto="item.nome"
        :valorProduto="item.preco"
        :img="item.img"
      ></Card-pizza-carrinho>
    </div>
  
  <h2  v-if="isBebida"> Bebidas</h2>
      <div
      style="display: inline-flex; max-width: 80%; flex-wrap: wrap"
      v-if="isBebida"
     
    >
      
      <Card-pizza-carrinho
       v-for="item in bebidas"
      v-bind:key="item.id"
        :nomeProduto="item.nome"
        :valorProduto="item.preco"
        :img="item.img"
      ></Card-pizza-carrinho>
    </div>
    <div
      class="button-container"
      style="
        justify-content: space-around;
        display: flex;
        position: fixed;
        width: 100%;
        bottom: 0;
        padding-top:10vh;
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
      isBebida: false,
      isPizza: true,
      pizzas: [
        { img: "frangoc.jpg", nome: "Pizza de frango com catupiry", preco: 35.00 },
        { img: "calabresa.jpg", nome: "Pizza de calabresa", preco: 35.00 },
        { img: "portuguesa.jpg", nome: "Pizza de manjericao", preco:40.00 },
        { img: "peperoni.jpg", nome: "Pizza de peperoni", preco: 35.00 },
      ],
        bebidas: [
        { img: "bebida.jpg", nome: "Coca-Cola", preco: 10.00 },
        { img: "bebida.jpg", nome: "Coca-Cola", preco: 10.00 },
        { img: "bebida.jpg", nome: "Guaraná", preco: 10.00 },
        { img: "bebida.jpg", nome: "Pepsi", preco: 10.00 },
        { img: "bebida.jpg", nome: "Dolly", preco: 10.00 },
      ],
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
  ...mapGetters('novoPedido',['getTotalPedido']),

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