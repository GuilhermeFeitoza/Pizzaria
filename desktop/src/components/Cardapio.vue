<template>
   <div>
    <br />
<div id ="headerActions"> 
       <img src="../assets/icons/mais.png" @click="openModal()">
      <img src="../assets/icons/lapis.png">
     
     
      
  </div>
    <h1 style="font-family: Calibri">Cardapio</h1>
    <div style="display: inline-flex; max-width: 70%">
      <div
        class="card"
        v-for="pedido in pedidos"
        :key="pedido.index"
        style=""
      >
        <img id="imgpedido" :src="pedido.img" />
        <span> Ingredientes </span>
        <ul v-for="item in ingredientes" :key="item.id">
          <li>{{ item.nome }}</li>
        </ul>
        
      </div>
    </div>
  </div>
</template>

<script>
export default {
     data() {
    return {
      ingredientes: [
        { id: 1, nome: "Camarao", preco: 13.0 },
        { id: 2, nome: "Calabresa", preco: 13.0 },
        { id: 3, nome: "Frango catupiry", preco: 13.0 },
        { id: 4, nome: "Toscana" },
      ],
      pedidos: [{img:require("../assets/imgs/brigadeiro.jpg")},
        {img:require("../assets/imgs/peperoni.jpg")},
        {img:require("../assets/imgs/manjericao.jpg")},
        {img:require("../assets/imgs/portuguesa.jpg")},
      
       
       ],
    }
     }
}
</script>

<style>

</style>