<template>
  <div>
    <br />

    <h1 style="font-family: Calibri">Últimos pedidos</h1>
     <card-pedidos :status="'E'"></card-pedidos>
     
    </div>

</template>

<script>
import CardPedidos from './card-pedidos.vue';
export default{

components:{
CardPedidos



}

  
}

</script>

<style>

</style>