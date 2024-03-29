export const modal = 'modal'

const state =  {
IsModalClienteOpen:false,
IsModalFuncionarioOpen:false,
IsModalPizzaOpen:false,
IsModalResumoOpen:false,



}
const getters = {

    getIsModalClienteOpen: (state) => state.IsModalClienteOpen,
    getIsModalFuncionarioOpen:(state) => state.IsModalFuncionarioOpen,
    getPizzaModalOpen:(state) => state.IsModalPizzaOpen,
    getResumoModalOpen:(state) => state.IsModalResumoOpen

}


const actions = {
    toggleModalCliente({commit}){
      
        commit('toggleModalCliente')   
       
    },
    toggleModalPizza({commit}){
      
        commit('toggleModalPizza')   
       
    },
    toggleModalFuncionario({commit}){
      
        commit('toggleModalFuncionario')   
       
    },
    toggleModalResumo({commit}){
      
        commit('toggleModalResumo')   
       
    },

}
const mutations = {

    toggleModalCliente(state){
        state.IsModalClienteOpen = !state.IsModalClienteOpen
        console.log(state.IsModalClienteOpen)
    },
    
    toggleModalFuncionario(state){
        state.IsModalFuncionarioOpen = !state.IsModalFuncionarioOpen

    },
    toggleModalPizza(state){
        state.IsModalPizzaOpen = !state.IsModalPizzaOpen

    },
    toggleModalResumo(state){

        state.IsModalResumoOpen = !state.IsModalResumoOpen
    }



}
export default{
    state,
    mutations,
    getters,
    actions    
}