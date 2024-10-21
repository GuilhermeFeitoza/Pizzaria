<template>
  <div>
    <h1>Produtos populares</h1>
    <div style="display: inline-flex; max-width:80%;flex-wrap: wrap;">
    <card-pizza
      :nomeProduto="'Portuguesa'"
      :numberOfSales="'100'"
      :imgSrc="'portuguesa.jpg'"
      :price="'R$50,00'"
      :description="''"
    ></card-pizza>
   
    
    </div>
  </div>
</template>

<script>
import CardPizza from "./card-produto.vue";
export default {
  components: {
    CardPizza,
  },
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

