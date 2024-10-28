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
    <router-link to="/pizzas" class="menu-text">
      <i class="icon-pizzas"></i>
      <span class="text-menu">Pizzas</span>
    </router-link>
    <router-link to="/bebidas" class="menu-text">
        <div class="icon-drink"></div>
        <span class="text-menu">Bebidas</span>
      </router-link>


    <router-link to="/clientes">
      <i class="bi bi-people-fill"></i>
      <span class="text-menu">Clientes</span>
    </router-link>
    <router-link to="/pedidos">
      <i class="bi bi-scooter"></i>
      <span class="text-menu">Pedidos</span>
    </router-link>
    <router-link to="/novopedido" class="menu-text">
      <div style="width: 10vw">
        <i class="bi bi-plus"></i>
        <span>Novo pedido</span>
      </div>
    </router-link>
    <router-link to="/ingredientes" class="menu-text">
      <div style="width: 10vw">
        <i class="icon-advanced"></i>
        <span>Ingredientes</span>
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

.icon-advanced {
  background: url('../assets/imgs/tomato.svg');
  background-repeat: no-repeat;
  background-size: cover; /* stretch the background to cover the whole element */
  display: inline-block;
  height: 20px;
  width: 20px;
}
.icon-drink {
  background: url('../assets/imgs/drinks.svg');
  background-repeat: no-repeat;
  background-size: cover; /* stretch the background to cover the whole element */
  display: inline-block;
  height: 30px;
  width: 30px;
}
.icon-pizzas{
  background: url('../assets/imgs/pizzas.svg');
  background-repeat: no-repeat;
  background-size: cover; /* stretch the background to cover the whole element */
  display: inline-block;
  height: 35px;
  width: 35px;

}
</style>