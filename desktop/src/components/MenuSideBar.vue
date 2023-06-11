<template>
  <div id="mySidebar" class="sidebar">
       <router-link to="/funcionarios" class="menu-text">
      
        <span>Funcionários</span>
      </router-link>
      <router-link to="/cardapio" class="menu-text">
        
        <span class="text-menu">Cardapio</span>
      </router-link>


      <router-link to="/clientes">
      
        <span class="text-menu">Clientes</span>
      </router-link>
      <router-link to="/pedidos">
       
        <span class="text-menu">Pedidos</span>
      </router-link>


  </div>
</template>

<script>
export default {
  methods: {
   
  },
};
</script>

<style>
#mySideBar {
  width: 15vw;
  margin-left: 15vw;
}
</style>