import VueRouter from "vue-router";
import Vue from "vue";
import Home from "./components/Home.vue"
import Clientes from "./components/Clientes.vue"

Vue.use(VueRouter)

const routes = [
    { name: 'Home',
     path: '/',
      component: Home },
    
 {  name:'Clientes',
     path: '/clientes',
     component: Clientes }
]

const router = new VueRouter({
    routes

})

export default router



