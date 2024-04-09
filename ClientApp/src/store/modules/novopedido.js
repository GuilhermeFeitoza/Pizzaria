export const novopedido = 'novopedido';

const state = {
    totalPedido: 0,
    itensPedido: [],
}
const getters = {
    getTotalPedido: (state) => state.totalPedido,
    getItensPedido:(state) => state.itensPedido,
}
const actions = {

    addTotalPedido({ commit }, valor) {
        commit("addTotalPedidoMutation", valor);

    }, removeTotalPedido({ commit }, valor) {
        commit("removeTotalPedidoMutation", valor);

    }, addProdutoPedido({ commit }, item) {

        commit("addProdutoPedido", item)

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


}

export default {
    state,
    mutations,
    getters,
    actions
}