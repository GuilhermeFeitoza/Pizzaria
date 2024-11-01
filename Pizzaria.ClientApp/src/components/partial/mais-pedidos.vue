<template>
  <div>
    <h1>Produtos populares</h1>
    <div style="display: inline-flex; max-width:80%;flex-wrap: wrap;" v-for="pedido in maisPedidos">
      <card-pizza :nomeProduto="pedido.Nome" :numberOfSales="pedido.NumeroDeVendas" :imgSrc="'noimage.png'" :price="''"
        :description="[]"></card-pizza>


    </div>
  </div>
</template>

<script>

import CardPizza from "./card-produto.vue";
import { mapActions } from "vuex";
export default {

  methods:{

    ...mapActions('pedidos', ['requestMaisPedidos']),
    
  },
  data() {
    return {
      maisPedidos: [],

    }

  },
  components: {
    CardPizza,
  },
  async mounted() {

    this.maisPedidos = await this.requestMaisPedidos();

  }
};
</script>

<style>
#cardPopulares {
  width: 50%;
  display: inline-flex;
  border: solid;
  border-color: black;
  border-width: 1px;

  margin-bottom: 5%;
  box-shadow: black;
}

#fotoPopular {
  width: 10vw;
  height: 10vw;
}
</style>
