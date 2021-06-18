<template>
   <div class="menu">
      <img id ="logo" src="../assets/logo.png" width="70" height="70"/>
      <nav id="linkmenu">
        <ul>
          <a>
          Clientes
          </a>
        </ul>
        <ul>
          <a>
          Funcionários
          </a>
        </ul>
        <ul>
          <a>
          Cardapio
          </a>
        </ul>
        <ul>
          <a>
          Pedidos
          </a>
        </ul>
        <ul>
          <a>
          Avaliações
          </a>
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
 ul{
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
 }
#welcome{
  font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
  font-weight:10px;
  position: absolute;
  right: 3vw;
  top:0vw;
}
#logo{
  position: fixed;
  left: 1px;
}
#sair{
  padding-left:10px;
 }
</style>
