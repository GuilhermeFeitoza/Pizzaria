<template>
  <div style="padding: 10px" class="card">
    <img class="img-card-cart" :src="require(`@/assets/imgs/${this.img}`)" />
    <br />
    <span>{{ this.nomeProduto }}</span>
    <br />
    <span class="price"
      ><b>R${{ formatPrice(this.valorProduto) }}</b></span
    >
    <div class="counter">
      <div class="btn" @click="addQuantidade">+</div>
      <div class="count">{{ this.quantidade }}</div>
      <div class="btn" @click="removeQuantidade">-</div>
    </div>
  </div>
</template>

<script>
import { mapActions } from "vuex";
export default {
  props: {
    idProduto:Number,
    bebida: false,
    img: "",
    valorProduto: Number,
    nomeProduto: "",
  },
  data() {
    return {
      quantidade: 0,
    };
  },
  methods: {
    ...mapActions("novoPedido", [
      "addTotalPedido",
      "removeTotalPedido",
      "addProdutoPedido",
    ]),
    addQuantidade() {
      this.quantidade = this.quantidade + 1;
      this.addTotalPedido(this.valorProduto);
      this.addItemPedido();
    },
    addItemPedido() {
      let pizza = {
        nome: this.nomeProduto,
        valor: this.valorProduto,
      };
      this.addProdutoPedido(pizza);
    },
    removeQuantidade() {
      if (this.quantidade > 0) {
        this.quantidade = this.quantidade - 1;
        this.removeTotalPedido(this.valorProduto);
      }
    },
    formatPrice(value) {
      let val = (value / 1).toFixed(2).replace(".", ",");
      return val.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ".");
    },
  },
};
</script>
<style scoped>
.counter {
  width: 100%;
  display: flex;
  justify-content: space-between;
  align-items: center;
  position: relative;
  bottom: -5vw;
 
}
.btn {
  width: 40px;
  height: 40px;
  border-radius: 50%;
  background-color: #d9d9d9;
  display: flex;
  justify-content: center;
  align-items: center;
  font-size: 20px;
  font-family: ‘Open Sans’;
  font-weight: 900;
  color: #202020;
  cursor: pointer;
  margin: 2px;
}
.count {
  font-size: 20px;
  font-family: ‘Open Sans’;
  font-weight: 900;
  color: #202020;
 
}
.price {

  font-size: 25px;
}
.card {
  max-width: 60%;
  max-height: 20vw;
  min-width: 20%;
  width: 20%;
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
  border-radius: 1.2vw;
  height: 20vw;
}
.img-card-cart{

    width: 50%;
    margin-left: 20%;
}
</style>