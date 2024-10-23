<template>
  <div>
    <div>
      <br />
      <div id="headerActions">
        <img src="../assets/icons/mais.png" @click="openModal()" />

      </div>
      <div class="main-container">
        <h1 style="font-family: Calibri">Pizzas</h1>
        <div style="display: inline-flex; max-width: 80%; flex-wrap: wrap" v-for="pizza in pizzas"
          v-bind:key="pizza.IdPizza">
          <card-pizza :id="pizza.IdPizza" :nomeProduto="pizza.Nome" :imgSrc="'noimage.png'" :price="pizza.Preco"
            :description="pizza.Ingredientes"></card-pizza>
        </div>
      </div>
    </div>
  </div>

</template>

<script>
import { mapActions } from 'vuex';
import CardPizza from "./partial/card-produto.vue";
import PizzaModal from "../components/modal/Pizza-modal.vue";
export default {
  data() {
    return {
      pizzas: [],
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
    PizzaModal
  },
  methods: {
    ...mapActions('modal', ['toggleModalPizza']),
    ...mapActions('pizzas', ['requestPizzas','getPizzaById']),
    openModal() {
      this.toggleModalPizza("insert");
    }

  },
  async mounted() {

    this.pizzas = await this.requestPizzas();


  }
};
</script>

<style></style>