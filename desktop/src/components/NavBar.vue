<template>
   <div class="menu">
      <img id ="logo" src="../assets/logo.png" width="100" height="50"/>
      <nav id="linkmenu">
        <ul>
          Clientes
        </ul>
        <ul>
          Funcionários
        </ul>
        <ul>
          Cardapio
        </ul>
        <ul>
          Pedidos
        </ul>
        <ul>
          Avaliações
        </ul>
      </nav>
        <div id ="welcome">
      <span>Seja Bem vindo Guilherme!!</span>
      <a id ="sair"><img src="../assets/exit.png"></a>
     </div>
   </div>
</template>

<script>
export default {
  name: 'NavBar'
}
</script>
<style scoped>
#linkmenu{
padding-left: 10vw;

}
.menu {
    left: 0;
    background-color: #dd7b05;
    height: 5vw;
    width: 100vw;
    position: absolute;
    top: 0;
}
#linkmenu {
  display: inline-flex;
 }
#welcome{
  font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
  font-weight:10px;
  position: absolute;
  right: 4vw;
  top:0vw;
}
#logo{
  float: left;
  position: fixed;
  left: 2px;
}
#sair{
  padding-left:10px;
 }
</style>
