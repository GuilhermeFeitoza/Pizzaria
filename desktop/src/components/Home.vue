<template>
  <div >

  <Ultimos-pedidos/>
  <Mais-pedidos/>
  

  </div>
</template>

<script>
import UltimosPedidos from './partial/ultimos-pedidos.vue'
import MaisPedidos from './partial/mais-pedidos.vue'



export default {
  components: {
    
    UltimosPedidos,
    MaisPedidos,
   

    }
};
</script>
<style scoped>

</style>