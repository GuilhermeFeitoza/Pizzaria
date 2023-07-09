<template>
  <div>
    <h1>Novo Pedido</h1>
    <span>Total do Pedido : <b>R${{this.getValorPedido}}</b></span>
    <div>
       <card-pizza
        :nomeProduto="'Portuguesa'"
        :imgSrc="'portuguesa.jpg'"
        :price="'R$50,00'"
        :description="'Mussarela,palmito,azeitona,presunto,ovo e ervilha'"
      ></card-pizza> 
    </div>
  </div>
</template>
<script>
import { mapActions, mapGetters } from 'vuex';
import CardPizza from "./partial/card-produto.vue";
export default {
  data() {
    return {
    valorPedido:0.0,
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
methods:{      
  ...mapActions('modal',['toggleModalPizza']),
  openModal(){
    this.toggleModalPizza();

  }


  },
  computed:{
    getValorPedido(){
        return this.valorPedido

    }


  }
};
</script>
