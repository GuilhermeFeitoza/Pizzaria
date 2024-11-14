<template>
  <div>
  
    <router-view></router-view>

  </div>
</template>
<script>
import IndexCliente from "./client/home/index-cliente.vue";
import EmployeeApp from "./EmployeeApp.vue";
export default {

  components: {
    IndexCliente,
    EmployeeApp
  }

}
</script>
