<template>
  <div>
    <br />

    <h1 style="font-family: Calibri">Últimos pedidos</h1>
    <div style="display: inline-flex; max-width: 70%">
      <div
        class="card"
        v-for="pedido in pedidos"
        :key="pedido.index"
        style=""
      >
        <img id="imgpedido" :src="pedido.img" />
        <ul v-for="item in itemsPedido" :key="item.id">
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
      itemsPedido: [
        { id: 1, nome: "Camarao", preco: 13.0 },
        { id: 2, nome: "Calabresa", preco: 13.0 },
        { id: 3, nome: "Frango catupiry", preco: 13.0 },
        { id: 4, nome: "Toscana" },
        { id: 5, nome: "Teste" },
      ],
      pedidos: [{img:require("../../assets/imgs/brigadeiro.jpg")},
        {img:require("../../assets/imgs/peperoni.jpg")},
        {img:require("../../assets/imgs/manjericao.jpg")},
        {img:require("../../assets/imgs/portuguesa.jpg")},
      
       
       ],
    }
    },
      
};
</script>

<style>
#imgpedido {
  width: 15vw;
  height: 10vw;
}
.card{
 box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2); 
 border-style: solid;
margin-left: 15px;

}
.card:hover {
  transform: scale(1.1); /* (150% zoom - Note: if the zoom is too large, it will go outside of the viewport) */
  
}
</style>