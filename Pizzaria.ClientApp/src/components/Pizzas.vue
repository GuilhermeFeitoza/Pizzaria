<template>
  <div>
    <br />
    <div id="headerActions">
      <img src="../assets/icons/mais.png" @click="openModal()" />

    </div>
    <h1 style="font-family: Calibri">Pizzas</h1>
    <div style="display: inline-flex; max-width: 80%; flex-wrap: wrap" v-for="pizza in pizzas" v-bind:key="pizza.IdPizza">
      <card-pizza :nomeProduto="pizza.Nome" :imgSrc="'calabresa.jpg'" :price="pizza.Preco"
        :description="pizza.Ingredientes"></card-pizza>
    </div>
  </div>
</template>

<script>
import { mapActions } from 'vuex';
import CardPizza from "./partial/card-produto.vue";
export default {
  data() {
    return {
      pizzas : [],
      pedidos: [
        { img: require("../assets/imgs/brigadeiro.jpg") },
        { img: require("../assets/imgs/peperoni.jpg") },
        { img: require("../assets/imgs/manjericao.jpg") },
        { img: require("../assets/imgs/portuguesa.jpg") },
      ],
    };
  },
  components: {
    CardPizza,
  },
  methods: {
    ...mapActions('modal', ['toggleModalPizza']),
    ...mapActions('pizzas', ['requestPizzas']),
    openModal() {
      this.toggleModalPizza();

    }


  },
 async mounted() {

    this.pizzas = await this.requestPizzas();


  }
};
</script>

<style></style>