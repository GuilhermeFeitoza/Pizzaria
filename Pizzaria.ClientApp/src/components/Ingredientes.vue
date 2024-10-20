<template>
  <div>
    <br />
    <div id="headerActions">
      <img src="../assets/icons/mais.png" @click="openModal()" />

    </div>
    <h1 style="font-family: Calibri">Ingredientes</h1>
    <div v-for="ingrediente in ingredientes" :key="ingrediente.id"
      style="display: inline-flex; max-width: 80%; flex-wrap: wrap">
      <ingrediente-item :preco="ingrediente.preco"
       :nome="ingrediente.nome"
       :kcal="ingrediente.kcal"
       ></ingrediente-item>
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
        { id: 1, nome: "Camarão",preco:10.00 ,kcal:89},
        { id: 2, nome: "Calabresa",preco:10.00 ,kcal:89 },
        { id: 3, nome: "Cheedar" ,preco:10.00 ,kcal:89 },
        { id: 4, nome: "Catupiry",preco:10.00 ,kcal:89  },
        { id: 5, nome: "Cebola",preco:10.00 ,kcal:89  },
        { id: 6, nome: "Alho",preco:5.00 ,kcal:89  },
        { id: 7, nome: "Peperoni",preco:10.00 ,kcal:89  },
        { id: 8, nome: "Cream cheese",preco:10.00,kcal:89   },
        { id: 9, nome: "Azeitona",preco:10.00,kcal:89   },
        { id: 10, nome: "Mussarela",preco:10.00 ,kcal:89  },

      ],
    };
  },
  components: {
    CardPizza,
    ingredienteItem
  },
  methods: {
    ...mapActions('modal', ['toggleModalIngrediente']),
    openModal() {
      this.toggleModalIngrediente();

    }


  }
};
</script>

<style></style>