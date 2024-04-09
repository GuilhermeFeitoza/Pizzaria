<template>
  <div style="margin-top:1vw">
    <div class="card" style="" >
      <span class="product-name-card">{{ this.nomeProduto }}</span>
         <img src="../../assets/icons/lapis.png" style="display:none"/>
      <img class="img-card" :src="require(`@/assets/imgs/${imgSrc}`)" />
      <div style="width: 10vw">
        <span class="product-description-card">{{ this.description }}</span>
      </div>
      <p class="product-price-card">{{ this.price }}</p>
      <p class="product-number-sales-card" v-show="isMaisVendidos">Número de vendas : {{ this.numberOfSales }}</p>
    </div>
  </div>
</template>

<script>
export default {
  props: {
    nomeProduto: String,
    imgSrc: null,
    description: String,
    price: String,
    numberOfSales: String,
 
  },
  computed: {
    isMaisVendidos() {
      if (this.numberOfSales != null) {
        return true;
      }else{
        return false;

      }
    },
  },
};
</script>

<style>
.isMenuScreen{

width:2vw;
height:2vw;
float:right;
display: block;

}
</style>