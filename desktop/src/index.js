import VueRouter from "vue-router";
import Vue from "vue";
import Home from "./components/Home.vue"
import Clientes from "./components/Clientes.vue"
import Funcionarios from "./components/Funcionarios.vue"
import Cardapio  from "./components/Cardapio.vue"
import Pedidos from "./components/Pedidos.vue"
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
},
{name:'Cardapio',
path:'/cardapio',
component: Cardapio,
},
{name:'Pedidos',
path:'/pedidos',
component: Pedidos,
}


]


const router = new VueRouter({
    routes

})

export default router



