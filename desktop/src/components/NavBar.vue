<template>
   <div class="menu">
      <router-link to="/">
      <img id ="logo" src="../assets/logo.png" width="70" height="70"/>
      </router-link>
   
        <div id ="welcome">
      <span>Seja Bem vindo {{nomeUsuario}}!!</span>
      <a id ="sair"><img src="../assets/exit.png"></a>
     </div>
      
   </div>
</template>

<script>
export default {
  name: 'NavBar',
  data () {
    return {
      nomeUsuario: 'Guilherme',
    }
  }
}

</script>

