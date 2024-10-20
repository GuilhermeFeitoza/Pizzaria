
const routes = [
    {
        name: 'Home',
        path: '/',
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
        name: 'Cardapio',
        path: '/cardapio',
        component: Cardapio,
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
    }, {
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
    routes

})

export default router
