<template>
  <div style="margin: auto;padding-left: 5%;">
    <div style="width: auto">
      <span class="menu-rounded imgFuncionarios"
        ><router-link to="/funcionarios" class="menu-text">
          Funcionários
        </router-link></span
      >
      <span class="menu-rounded imgCardapio "
        ><router-link to="/cardapio" class="menu-text">
          Cardapio
        </router-link></span
      >

      <span class="menu-rounded imgAvaliacao"><a class="menu-text"> Avaliações </a></span>
      <span class="menu-rounded imgCliente">
        <router-link class="menu-text" to="/clientes">
          Clientes
        </router-link></span
      >
      <span class="menu-rounded imgPedidos">
        <router-link to="" class="menu-text"> Pedidos </router-link></span
      >
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