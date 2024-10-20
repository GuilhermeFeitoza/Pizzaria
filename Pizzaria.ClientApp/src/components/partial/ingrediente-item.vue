<template>


<div style="margin-top:1vw">
    <div class="card" style="" >
      <span class="product-name-card">{{ this.nome }}</span>
      <p class="product-price-card">R${{ this.preco }}</p>
      <p class="product-price-card">Calorias : {{ this.kcal }}</p>
    </div>
  </div>
</template>


<script>
export default {
  props: {
    nome: String,
    preco: String,
    kcal: 0,
  },
  computed: {
    
  },
};
</script>
