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
import { mapActions, mapGetters } from 'vuex';
import CardPizza from "./partial/card-produto.vue";
import ingredienteItem from './partial/ingrediente-item.vue';
export default {
  data() {
    return {
      ingredientes: [],
    };
  },
  components: {
    CardPizza,
    ingredienteItem
  }, computed: {
    ...mapGetters("modal", ["getModalIngredientesOptions"]),
    visible() {
      return this.getModalIngredientesOptions.visible;
    }
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
  }, watch: {
    async visible() {
      this.ingredientes = await this.requestIngredientes();

    }

  }
};
</script>



<style></style>