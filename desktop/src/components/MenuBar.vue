<template>
  <div class="menuButtons">
      <div style="">
      <router-link to="/funcionarios" class="menu-text">
        <div class="menu-rounded imgFuncionarios">  </div>
        <span class="text-menu" style="position:relative;right:9vw">Funcionários</span>
      </router-link>
      <router-link to="/cardapio" class="menu-text">
        <div class="menu-rounded imgCardapio"></div>
        <span class="text-menu">Cardapio</span>
      </router-link>

      <!-- <span class="menu-rounded imgAvaliacao"
        ><a class="menu-text"> Avaliações </a></span
      > -->
      <router-link to="/clientes">
        <div class="menu-rounded imgCliente"></div>
        <span class="text-menu">Clientes</span>
      </router-link>
      <router-link to="">
        <div class="menu-rounded imgPedidos"> </div>
        <span class="text-menu">Pedidos</span>
      </router-link>



    </div>

    <!-- 

    <span class="menu-rounded"></span>
    <span class="menu-rounded"></span>
    <span class="menu-rounded"></span> -->
  </div>
</template>

<script>
export default {};
</script>

<style>
</style>