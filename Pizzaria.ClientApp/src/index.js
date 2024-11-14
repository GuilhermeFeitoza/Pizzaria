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
import Bebidas from './components/Bebidas.vue';
import Avaliacoes from "./components/Avaliacoes.vue";
import IndexCliente from "./client/home/index-cliente.vue";
import EmployeeApp from "./EmployeeApp.vue";
Vue.use(VueRouter)

const routes = [


    {
        name: 'Clientes',
        path: 'admin/clientes',
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
        path: '/pizzas',
        component: Pizzas,
    },
    {
        name: 'Pedidos',
        path: '/pedidos',
        component: Pedidos,
    },
    {
        name: 'Login',
        path: '/login',
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

    },
    {
        name: 'Bebidas',
        path: '/bebidas',
        component: Bebidas

    },
    {
        name: 'Avaliações',
        path: '/avaliacoes',
        component: Avaliacoes

    },
    {
        name: 'Admin',
        path: '/admin',
        component: EmployeeApp

    },
    {
        name: 'Home',
        path: '/home',
        component: IndexCliente
    }
   


]


const router = new VueRouter({
    routes,
    mode: 'history',

})

export default router



