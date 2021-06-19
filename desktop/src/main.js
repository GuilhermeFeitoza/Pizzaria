import Vue from 'vue'
import App from './App.vue'
import '../src/style.css'
import VueRouter from "vue-router";
import Home from "./components/Home.vue"
import Clientes from "./components/Clientes.vue"
import  router from '../src/index.js'

Vue.config.productionTip = false

new Vue({

  render: h => h(App),
  router,
}).$mount('#app')
