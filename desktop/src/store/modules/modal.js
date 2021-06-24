export const modal = 'modal'

const state =  {
IsModalClienteOpen:false,
IsModalFuncionarioOpen:false,



}
const getters = {

    getIsModalClienteOpen: (state) => state.IsModalClienteOpen,
    getIsModalFuncionarioOpen:(state) => state.IsModalFuncionarioOpen

}


const actions = {
    toggleModalCliente({commit}){
      
        commit('toggleModalCliente')   
       
    },
    toggleModalFuncionario({commit}){
      
        commit('toggleModalFuncionario')   
       
    }
}
const mutations = {

    toggleModalCliente(state){
        state.IsModalClienteOpen = !state.IsModalClienteOpen
        console.log(state.IsModalClienteOpen)
    },
    
    toggleModalFuncionario(state){
        state.IsModalFuncionarioOpen = !state.IsModalFuncionarioOpen

    }



}
export default{
    state,
    mutations,
    getters,
    actions    
}