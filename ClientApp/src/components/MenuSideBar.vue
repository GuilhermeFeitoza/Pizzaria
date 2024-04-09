<template>
  <div id="mySidebar" class="sidebar">
    <router-link to="/home">
      <i class="bi bi-house"></i>
      <span>Home</span>
    </router-link>
    <router-link to="/funcionarios" class="menu-text">
      <div style="width: 10vw">
        <i class="bi bi-person-workspace"></i>
        <span>Funcionários</span>
      </div>
    </router-link>
    <router-link to="/cardapio" class="menu-text">
      <i class="bi bi-card-heading"></i>
      <span class="text-menu">Cardapio</span>
    </router-link>

    <router-link to="/clientes">
      <i class="bi bi-people-fill"></i>
      <span class="text-menu">Clientes</span>
    </router-link>
    <router-link to="/pedidos">
    <!-- <i class="bi bi-caret-right-fill" style="
    font-size: 10px;
"></i> -->
      <i class="bi bi-scooter"></i>
      <span class="text-menu">Pedidos</span>
    </router-link>
    <router-link to="/novopedido" class="menu-text">
      <div style="width: 10vw">
        <i class="bi bi-plus"></i>
        <span>Novo pedido</span>
      </div>
    </router-link>
  </div>
</template>

<script>
export default {
  methods: {},
};
</script>

<style>
#mySideBar {
  width: 16vw;
  margin-left: 15vw;
}
.menu-text {
  position: relative;
  left: 0px;
}
</style>