<template>


  <div style="margin-top:1vw">
    <div class="card" style="">
      <span class="product-name-card">{{ this.nome }}</span>
      <p class="product-price-card">R${{ this.preco }}</p>
      <p class="product-price-card">Calorias : {{ this.qtdCal }}</p>
    </div>
    <div class="action-icon">
      <img src="../../assets/icons/lapis.png" @click="updateIngredienteClick(id)" height="30" width="30">
      <img src="../../assets/icons/lixo.png" @click="deleteIngredienteClick(id)" height="30" width="30">
    </div>
  </div>
</template>


<script>
import { mapActions } from "vuex";
export default {

  props: {
    id: Number,
    nome: String,
    preco: Number,
    qtdCal: 0,
  },
  computed: {

  },
  methods: {
    ...mapActions("ingredientes", ["deleteIngrediente", "setSelectedIngrediente"]),
    ...mapActions("modal", ["toggleModalIngrediente"]),


    async deleteIngredienteClick(id) {

      if (await this.deleteIngrediente(id)) {
        alert("Excluido com sucesso!!")

      }

    },

    async updateIngredienteClick(id) {
      this.setSelectedIngrediente(id);
      this.toggleModalIngrediente('update');
    }


  }



};
</script>
<style>
.action-icon {

  cursor: pointer;
  float: right;
  position: relative;
  bottom: 15vh;

}
</style>
