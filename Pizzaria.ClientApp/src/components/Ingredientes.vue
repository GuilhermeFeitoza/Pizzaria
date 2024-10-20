<template>
  <div>
    <br />
    <div id="headerActions">
      <img src="../assets/icons/mais.png" @click="openModalAdd()" />

    </div>
    <h1 style="font-family: Calibri">Ingredientes</h1>
    <div v-for="ingrediente in ingredientes" :key="ingrediente.id"
      style="display: inline-flex; max-width: 80%; flex-wrap: wrap">
      <ingrediente-item :preco="ingrediente.preco" :id="ingrediente.idIngrediente" :nome="ingrediente.nome"
        :qtdCal="ingrediente.qtdCal"></ingrediente-item>
    </div>
  </div>
</template>

<script>
import { mapActions } from 'vuex';
import CardPizza from "./partial/card-produto.vue";
import ingredienteItem from './partial/ingrediente-item.vue';
export default {
  data() {
    return {
      ingredientes: [
        { idIngrediente: 1, nome: "Camarão", preco: 10.00, qtdCal: 89 },
        { idIngrediente: 2, nome: "Calabresa", preco: 10.00, qtdCal: 89 },
        { idIngrediente: 3, nome: "Cheedar", preco: 10.00, qtdCal: 89 },
        { idIngrediente: 4, nome: "Catupiry", preco: 10.00, qtdCal: 89 },
        { idIngrediente: 5, nome: "Cebola", preco: 10.00, qtdCal: 89 },
        { idIngrediente: 6, nome: "Alho", preco: 5.00, qtdCal: 89 },
        { idIngrediente: 7, nome: "Peperoni", preco: 10.00, qtdCal: 89 },
        { idIngrediente: 8, nome: "Cream cheese", preco: 10.00, qtdCal: 89 },
        { idIngrediente: 9, nome: "Azeitona", preco: 10.00, qtdCal: 89 },
        { idIngrediente: 10, nome: "Mussarela", preco: 10.00, qtdCal: 89 },

      ],
    };
  },
  components: {
    CardPizza,
    ingredienteItem
  },
  methods: {
    ...mapActions('modal', ['toggleModalIngrediente']),
    ...mapActions('ingredientes', ['requestIngredientes']),
    openModalAdd() {
      this.toggleModalIngrediente('insert');

    }


  },
  async mounted() {
    this.ingredientes = await this.requestIngredientes();
  }
};
</script>



<style></style>