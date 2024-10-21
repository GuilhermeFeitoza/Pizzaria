<template>
  <div style="display: inline">
    <br />
    <div id="headerActions">
      <router-link to="/novopedido" class="menu-text" style="float: right">
        <span>Novo pedido</span>
      </router-link>
    </div>
    <div class="main-container">
      <card-pedidos :dataPedido="'Terça-Feira,11 de agosto de 2022 20:05'" :precoPedido="'35,00'" :status="'E'"
        :tipoPedido="'DELIVERY'"></card-pedidos>
      <card-pedidos :dataPedido="'Quinta-Feira,09 de dezembro de 2022 20:05'" :status="'E'" :precoPedido="'23,00'"
        :tipoPedido="'RETIRADA'"></card-pedidos>
      <card-pedidos :dataPedido="'Sabádo,31 de setembro de 2022 20:05'" :status="'E'" :precoPedido="'55,00'"
        :tipoPedido="'DELIVERY'"></card-pedidos>
      <card-pedidos :dataPedido="'Segunda-Feira,21 de dezembro de 2022 20:05'" :status="'E'" :precoPedido="'33,00'"
        :tipoPedido="'RETIRADA'"></card-pedidos>
      <card-pedidos :dataPedido="'Sabádo,31 de setembro de 2022 20:05'" :status="'E'" :precoPedido="'55,00'"
        :tipoPedido="'DELIVERY'"></card-pedidos>
      <card-pedidos :dataPedido="'Segunda-Feira,21 de dezembro de 2022 20:05'" :status="'E'" :precoPedido="'33,00'"
        :tipoPedido="'RETIRADA'"></card-pedidos>
    </div>
  </div>
</template>

<script>
import CardPedidos from "./partial/card-pedidos.vue";
export default {
  components: {
    CardPedidos,
  },
};
</script>

<style></style>