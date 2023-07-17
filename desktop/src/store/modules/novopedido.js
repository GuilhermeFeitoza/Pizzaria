export const novopedido = 'novopedido';

const state = {
    totalPedido: 0,
}
const getters = {
    getTotalPedido: (state) => state.totalPedido,
}
const actions = {

    addTotalPedido({ commit }, valor) {
          commit("addTotalPedidoMutation", valor);

    },removeTotalPedido({commit},valor){
        commit("removeTotalPedidoMutation", valor);

    }
}


const mutations = {

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