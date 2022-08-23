<template>
  <div>
    <br />

    <h1 style="font-family: Calibri">Últimos pedidos</h1>
    <div style="display: inline-flex; max-width:100%;flex-wrap: wrap;">
     <card-pedidos :status="'E'"></card-pedidos>
     <card-pedidos :status="'E'"></card-pedidos>
     <card-pedidos :status="'E'"></card-pedidos>
     <card-pedidos :status="'E'"></card-pedidos>
    </div>
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