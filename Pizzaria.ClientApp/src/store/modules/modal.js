export const modal = 'modal'

const state = {

    modalFuncionarioOptions: {
        visible: false,
        action: 'insert'
    },
    modalIngredienteOptions: {
        visible: false,
        action: 'insert'
    },
    modalPizzaOptions: {
        visible: false,
        action: 'insert'
    },
    modalBebidaOptions: {
        visible: false,
        action: 'insert'
    },
    modalClienteOptions: {
        visible: false,
        action: 'insert'
    },
    IsModalPizzaOpen: false,
    IsModalResumoOpen: false,
    IsDetailsModalOpen: false,
    detalhesModalData: [],



}
const getters = {

    getModalClienteOptions: (state) => state.modalClienteOptions,
    getModalBebidaOptions: (state) => state.modalBebidaOptions,
    getModalFuncionarioOptions: (state) => state.modalFuncionarioOptions,
    getPizzaModalOptions: (state) => state.modalPizzaOptions,
    getResumoModalOpen: (state) => state.IsModalResumoOpen,
    getModalIngredientesOptions: (state) => state.modalIngredienteOptions,
    getDetailsModalOpen: (state) => state.IsDetailsModalOpen,
    getDetalhesModalData: (state) => state.detalhesModalData,

}


const actions = {
    toggleModalCliente({ commit }, action) {
        commit('toggleModalCliente', action)
    },
    toggleModalPizza({ commit }, action) {
        commit('toggleModalPizza', action)

    },
    toggleModalFuncionario({ commit }, action) {

        commit('toggleModalFuncionario', action)

    },
    toggleModalResumo({ commit }) {

        commit('toggleModalResumo')

    },
    toggleModalBebida({ commit }, action) {

        commit('toggleModalBebida', action)
    },

    toggleModalIngrediente({ commit }, action) {

        commit('toggleModalIngrediente', action)

    },

    toggleModalDetalhes({ commit }, obj) {
        commit('toggleModalDetalhes', obj);
    },


}
const mutations = {

    toggleModalCliente(state, action) {
        state.modalClienteOptions.visible = !state.modalClienteOptions.visible
        state.modalClienteOptions.action = action;
    },

    toggleModalFuncionario(state, action) {
        state.modalFuncionarioOptions.visible = !state.modalFuncionarioOptions.visible
        state.modalFuncionarioOptions.action = action;

    },
    toggleModalPizza(state, action) {
        state.modalPizzaOptions.action = action;
        state.modalPizzaOptions.visible = !state.modalPizzaOptions.visible;

    },
    toggleModalResumo(state) {

        state.IsModalResumoOpen = !state.IsModalResumoOpen
    },
    toggleModalIngrediente(state, action) {

        state.modalIngredienteOptions.visible = !state.modalIngredienteOptions.visible
        state.modalIngredienteOptions.action = action;
    },
    toggleModalBebida(state, action) {
        state.modalBebidaOptions.visible = !state.modalBebidaOptions.visible
        state.modalBebidaOptions.action = action;
    },
    toggleModalDetalhes(state, obj) {
        state.IsDetailsModalOpen = !state.IsDetailsModalOpen
        state.detalhesModalData = obj;
    },






}
export default {
    state,
    mutations,
    getters,
    actions
}