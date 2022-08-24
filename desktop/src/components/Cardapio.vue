<template>
  <div>
    <br />
    <div id="headerActions">
      <img src="../assets/icons/mais.png" @click="openModal()" />
      <img src="../assets/icons/lapis.png" />
    </div>
    <h1 style="font-family: Calibri">Cardapio</h1>
    <div style="display: inline-flex; max-width: 100%; flex-wrap: wrap">
      <card-pizza
        :nomeProduto="'Portuguesa'"
        :imgSrc="'portuguesa.jpg'"
        :price="'R$50,00'"
        :description="'Mussarela,palmito,azeitona,presunto,ovo e ervilha'"
      ></card-pizza>
      <card-pizza
        :nomeProduto="'Margherita'"
        :imgSrc="'manjericao.jpg'"
        :price="'R$45,00'"
        :description="'Mussarela,tomate e manjericão'"
      ></card-pizza>
      <card-pizza
        :nomeProduto="'Pepperoni'"
        :imgSrc="'peperoni.jpg'"
        :price="'R$60,00'"
        :description="'Mussarela e pepperoni'"
      ></card-pizza>
      <card-pizza
        :nomeProduto="'Frango com catupiry'"
        :imgSrc="'frangoc.jpg'"
        :price="'R$50,00'"
        :description="'Mussarela,Frango,azeitona e catupiry'"
      ></card-pizza>
      <card-pizza
        :nomeProduto="'Calabresa'"
        :imgSrc="'calabresa.jpg'"
        :price="'R$40,00'"
        :description="'Calabresa e cebola'"
      ></card-pizza>
    </div>
  </div>
</template>

<script>
import CardPizza from "./partial/card-produto.vue";
export default {
  data() {
    return {
      ingredientes: [
        { id: 1, nome: "Camarao", preco: 13.0 },
        { id: 2, nome: "Calabresa", preco: 13.0 },
        { id: 3, nome: "Frango catupiry", preco: 13.0 },
        { id: 4, nome: "Toscana" },
      ],
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
};
</script>

<style>
</style>