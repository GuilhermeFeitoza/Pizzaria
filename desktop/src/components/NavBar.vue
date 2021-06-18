<template>
   <header class="menu">
      <img src="../assets/logo.png" width="150" height="100"/>
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
      <a id ="sair">Sair</a>
     </div>
      </header>
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
  background-color: #dd7b05;
  height: 10vw;
  width: auto;
}
#linkmenu {
  display: inline-flex;
}
#welcome{
  font-family:'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
  font-weight:10px;
  position: absolute;
  right: 30px;
  padding-top:15;
}
img{
  float: left;
  position: fixed;
  left: 2px;
}
#sair{
  padding-left:10px;
 }
</style>
