<template>
  <div>

  <Ultimos-pedidos/>
  <Mais-pedidos/>
  

  </div>
</template>

<script>
import UltimosPedidos from '../components/partial/UltimosPedidos.vue'
import MaisPedidos from '../components/partial/MaisPedidos.vue'



export default {
  components: {
    
    UltimosPedidos,
    MaisPedidos,
   

    }
};
</script>
<style scoped>

</style>