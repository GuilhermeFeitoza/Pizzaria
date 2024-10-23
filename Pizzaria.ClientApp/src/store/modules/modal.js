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
    IsModalPizzaOpen: false,
    IsModalResumoOpen: false,
    IsModalClienteOpen: false,



}
const getters = {

    getIsModalClienteOpen: (state) => state.IsModalClienteOpen,
    getModalFuncionarioOptions: (state) => state.modalFuncionarioOptions,
    getPizzaModalOptions: (state) => state.modalPizzaOptions,
    getResumoModalOpen: (state) => state.IsModalResumoOpen,
    getModalIngredientesOptions: (state) => state.modalIngredienteOptions,

}


const actions = {
    toggleModalCliente({ commit }) {
        commit('toggleModalCliente')
    },
    toggleModalPizza({ commit },action) {
        commit('toggleModalPizza',action)

    },
    toggleModalFuncionario({ commit }, action) {

        commit('toggleModalFuncionario', action)

    },
    toggleModalResumo({ commit }) {

        commit('toggleModalResumo')

    },

    toggleModalIngrediente({ commit }, action) {

        commit('toggleModalIngrediente', action)

    },

}
const mutations = {

    toggleModalCliente(state) {
        state.IsModalClienteOpen = !state.IsModalClienteOpen
        console.log(state.IsModalClienteOpen)
    },

    toggleModalFuncionario(state, action) {
        state.modalFuncionarioOptions.visible = !state.modalFuncionarioOptions.visible
        state.modalFuncionarioOptions.action = action;

    },
    toggleModalPizza(state,action) {
        state.modalPizzaOptions.action = action;
        state.modalPizzaOptions.visible = !state.modalPizzaOptions.visible;
       
    },
    toggleModalResumo(state) {

        state.IsModalResumoOpen = !state.IsModalResumoOpen
    },
    toggleModalIngrediente(state, action) {

        state.modalIngredienteOptions.visible = !state.modalIngredienteOptions.visible
        state.modalIngredienteOptions.action = action;
    }




}
export default {
    state,
    mutations,
    getters,
    actions
}