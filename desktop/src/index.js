import VueRouter from "vue-router";
import Vue from "vue";
import Home from "./components/Home.vue"
import Clientes from "./components/Clientes.vue"
import Funcionarios from "./components/Funcionarios.vue"
Vue.use(VueRouter)

const routes = [
    { name: 'Home',
     path: '/',
      component: Home },
    
 {  name:'Clientes',
     path: '/clientes',
     component: Clientes }
,
{name:'Funcionarios',
path:'/funcionarios',
component: Funcionarios,
}


]


const router = new VueRouter({
    routes

})

export default router



