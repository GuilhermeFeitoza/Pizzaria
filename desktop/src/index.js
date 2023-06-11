import VueRouter from "vue-router";
import Vue from "vue";
import Home from "./components/Home.vue"
import Clientes from "./components/Clientes.vue"
import Funcionarios from "./components/Funcionarios.vue"
import Cardapio  from "./components/Cardapio.vue"
import Pedidos from "./components/Pedidos.vue"
import Login from "./components/login.vue"
Vue.use(VueRouter)

const routes = [
    
{ name: 'Home',
     path: '/home',
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
},
{name:'Login',
path:'/',
component: Login,
}



]


const router = new VueRouter({
    routes,
    mode: 'history',

})

export default router



