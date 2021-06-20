<template>
  <div id="app">
<header>
    <NavBar/>
</header>
<br>
      <br>
      <br>
      <br>
    <router-view/>

  </div>
</template>
<script>
import NavBar from './components/NavBar.vue'
import Home from './components/Home.vue'

import '../src/style.css'


export default {
  name: 'App',
  components: {
    NavBar,
    Home,
    
   }
}
</script>
