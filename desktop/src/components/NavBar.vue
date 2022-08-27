<template>
   <div class="menu">
      <router-link to="/home">
      <img id ="logo" src="../assets/logo.png"  />
      </router-link>
   
        <div id ="welcome">
     
      <router-link id ="sair" to="/login" >
 <span>Seja Bem vindo {{nomeUsuario}}!!</span>
              <img  src="../assets/exit.png" to="/login">
      </router-link>
     </div>
      
   </div>
</template>

<script>
import { mapActions } from 'vuex'
export default {
  name: 'NavBar',
  data () {
    return {
      nomeUsuario: 'Guilherme',
    }
  },
  methods:{
    ...mapActions('login',['logout']),
    


  }
}

</script>

