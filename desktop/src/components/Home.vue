<template>
  <div>
  <Ultimos-pedidos/>
  <Mais-pedidos/>
  

  </div>
</template>

<script>
import UltimosPedidos from './UltimosPedidos.vue'
import MaisPedidos from './MaisPedidos.vue'

export default {
  components: {
    
    UltimosPedidos,
    MaisPedidos
    }
};
</script>
<style scoped>

</style>