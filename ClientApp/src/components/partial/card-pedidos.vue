<template>
  <div class="card-pedidos" :class="{ maisDetalhes: moreDetails }">
    
    <span style="margin-left:0.5vw">
      {{ this.dataPedido }}
    </span>
   
    <br />
    <br />
    <span class="card-pedidos-status-text" style="">
      <img class="icon-size" :src="require(`@/assets/icons/${imgStatus}`)" />
      <span>{{ this.status == "E" ? "ENTREGUE" : "PREPARANDO" }}</span>
       <span class="card-pedidos-type-text">
      {{ this.tipoPedido }}   
    </span>
    </span>
    <br />
    <span style="font-weigth: bold; margin-left:0.5vw"> 
        R${{ this.precoPedido }} 
       <img
        class="icon-size detalhes-pedido"
        @click="toggleMoreDetails"
        src="../../assets/icons/setabaixo.png"
      />    
    </span>

    <div v-show="moreDetails">
      <p>1x Pizza de mussarela</p>
      <p>1x Pizza de brigadeiro</p>
      <p>1x Coca-cola zero</p>
     
      <h3>Forma de pagamento</h3>
      <p>Cartão de crédito</p>
      <br />
      <h3>Endereço entrega</h3>
      <p>Avenida paulista</p>
    </div>
  </div>
</template>

<script>
export default {
  props: {
    status: "E",
    dataPedido: "",
    precoPedido: "",
    tipoPedido: "",
  },
  data() {
    return {
      moreDetails: false,
    };
  },

  methods: {
    toggleMoreDetails() {
      this.moreDetails = !this.moreDetails;
      return this.moreDetails;
    },
  },
  computed: {
    imgStatus() {
      if (this.status == "E") {
        return "check.png";
      }
    },
  },
};
</script>

<style>
.maisDetalhes {
  height: 27vw;
}
</style>