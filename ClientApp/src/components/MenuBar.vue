<template>
  <div class="menuButtons">
      <div style=" padding-left:27vw;">
      <router-link to="/funcionarios" class="menu-text">
        <div class="menu-rounded imgFuncionarios">  </div>
        <span class="text-menu" style="position:relative;right:9vw">Funcionários</span>
      </router-link>
      <router-link to="/cardapio" class="menu-text">
        <div class="menu-rounded imgCardapio"></div>
        <span class="text-menu">Cardapio</span>
      </router-link>


      <router-link to="/clientes">
        <div class="menu-rounded imgCliente"></div>
        <span class="text-menu">Clientes</span>
      </router-link>
      <router-link to="/pedidos">
        <div class="menu-rounded imgPedidos"> </div>
        <span class="text-menu">Pedidos</span>
      </router-link>



    </div>
  </div>
</template>

<script>
export default {};
</script>
