<template>


  <div style="margin-top:1vw">
    <div class="card" style="">
      <span class="product-name-card">{{ this.nome }}</span>
      <p class="product-price-card">R${{ this.preco }}</p>
    </div>
    <div class="action-icon">
      <img src="../../assets/icons/lapis.png" @click="updateBebidaClick(id)" height="30" width="30">
      <img src="../../assets/icons/lixo.png" @click="deleteBebidaClick(id)" height="30" width="30">
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
  },
  computed: {

  },
  methods: {
    ...mapActions("bebidas", ["deleteBebida", "setSelectedBebida"]),
    ...mapActions("modal", ["toggleModalBebida"]),


    async deleteBebidaClick(id) {

      if (await this.deleteBebida(id)) {
        alert("Excluido com sucesso!!")

      }

    },

    async updateBebidaClick(id) {
      this.setSelectedBebida(id);
      this.toggleModalBebida('update');
    }


  }



};
</script>
<style>
.action-icon {

  cursor: pointer;
  float: right;
  position: relative;
  bottom: 12vh;

}
</style>
