export const novopedido = 'novopedido';
const axios = require('axios');
const urlBase = "https://localhost:5001";
const state = {
    totalPedido: 0,
    itensPedido: [],
}
const getters = {
    getTotalPedido: (state) => state.totalPedido,
    getItensPedido: (state) => state.itensPedido,
}
const actions = {

    addTotalPedido({ commit }, valor) {
        commit("addTotalPedidoMutation", valor);

    }, removeTotalPedido({ commit }, valor) {
        commit("removeTotalPedidoMutation", valor);

    }, addProdutoPedido({ commit }, item) {

        commit("addProdutoPedido", item)

    },
    clearPedido({ commit }) {
        commit("clearPedido")
    },

    async createPedido({ commit }, payload) {
        try {
            var response = await axios.post(urlBase + '/api/pedidos',payload)
            var jsonResponse = JSON.parse(JSON.stringify(response.data));

        } catch (error) {
           

        }


        commit("clearPedido")
    }
}


const mutations = {
    addProdutoPedido(state, item) {
        state.itensPedido.push(item);
    },
    addTotalPedidoMutation(state, valor) {

        state.totalPedido = state.totalPedido + valor;

    },
    removeTotalPedidoMutation(state, valor) {

        state.totalPedido = state.totalPedido - valor;

    },
    clearPedido(state) {
        state.totalPedido = 0.0;
        state.itensPedido = [];
    }


}

export default {
    state,
    mutations,
    getters,
    actions
}