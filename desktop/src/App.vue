<template>
  <div id="app">
<header>
   <NavBar/>
</header>
<br>
<body>
   <Home/>
</body>
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
    Home
  }
}
</script>
