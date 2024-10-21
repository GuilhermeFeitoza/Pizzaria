import VueRouter from "vue-router";
import Vue from "vue";
import Home from "./components/Home.vue"
import Clientes from "./components/Clientes.vue"
import Funcionarios from "./components/Funcionarios.vue"
import Pizzas from "./components/Pizzas.vue"
import Pedidos from "./components/Pedidos.vue"
import Login from "./components/login.vue"
import NovoPedido from "./components/NovoPedido.vue"
import Ingredientes from "./components/Ingredientes.vue";
Vue.use(VueRouter)

const routes = [

    {
        name: 'Home',
        path: '/home',
        component: Home
    },

    {
        name: 'Clientes',
        path: '/clientes',
        component: Clientes
    }
    ,
    {
        name: 'Funcionarios',
        path: '/funcionarios',
        component: Funcionarios,
    },
    {
        name: 'Pizzas',
        path: '/cardapio',
        component: Pizzas,
    },
    {
        name: 'Pedidos',
        path: '/pedidos',
        component: Pedidos,
    },
    {
        name: 'Login',
        path: '/',
        component: Login,
    },
    {
        name: 'NovoPedido',
        path: '/novopedido',
        component: NovoPedido

    },
    {
        name: 'Ingredientes',
        path: '/ingredientes',
        component: Ingredientes

    }



]


const router = new VueRouter({
    routes,
    mode: 'history',

})

export default router



