import modal from './modules/modal';
import cliente  from './modules/clientes';
import login from './modules/login';

import Vue from 'vue';
import Vuex from 'vuex';
import funcionarios from './modules/funcionarios';
import novoPedido from './modules/novopedido';
import ingredientes  from './modules/ingredientes';
import pizzas from './modules/pizza'
import bebidas from './modules/bebidas';

Vue.use(Vuex);

export default new Vuex.Store({
  modules: {
    modal: { namespaced: true, ...modal },
    cliente:{namespaced:true, ...cliente},
    login : { namespaced: true , ...login},
    funcionarios:{namespaced:true,...funcionarios},
    novoPedido:{namespaced:true,...novoPedido},
    ingredientes:{namespaced:true,...ingredientes},
    pizzas: {namespaced:true,...pizzas},
    bebidas : {namespaced:true,...bebidas}
  }
});






