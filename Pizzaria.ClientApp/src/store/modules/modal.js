export const modal = 'modal'

const state =  {
IsModalClienteOpen:false,
modalFuncionarioOptions:{
    visible : false,
    mode: 'insert'

},
IsModalPizzaOpen:false,
IsModalResumoOpen:false,
IsModalIngredienteOpen:false,



}
const getters = {

    getIsModalClienteOpen: (state) => state.IsModalClienteOpen,
    getModalFuncionarioOptions:(state) => state.modalFuncionarioOptions,
    getPizzaModalOpen:(state) => state.IsModalPizzaOpen,
    getResumoModalOpen:(state) => state.IsModalResumoOpen,
    getIngredienteModalIsOpen:(state)  => state.IsModalIngredienteOpen,

}


const actions = {
    toggleModalCliente({commit}){
        commit('toggleModalCliente')   
    },
    toggleModalPizza({commit}){
      
        commit('toggleModalPizza')   
       
    },
    toggleModalFuncionario({commit},action){
      
        commit('toggleModalFuncionario',action)   
       
    },
    toggleModalResumo({commit}){
      
        commit('toggleModalResumo')   
       
    },

    toggleModalIngrediente({commit}){
      
        commit('toggleModalIngrediente')   
       
    },

}
const mutations = {

    toggleModalCliente(state){
        state.IsModalClienteOpen = !state.IsModalClienteOpen
        console.log(state.IsModalClienteOpen)
    },
    
    toggleModalFuncionario(state,action){
        state.modalFuncionarioOptions.visible = !state.modalFuncionarioOptions.visible
        state.modalFuncionarioOptions.action = action;

    },
    toggleModalPizza(state){
        state.IsModalPizzaOpen = !state.IsModalPizzaOpen

    },
    toggleModalResumo(state){

        state.IsModalResumoOpen = !state.IsModalResumoOpen
    },
    toggleModalIngrediente(state){

        state.IsModalIngredienteOpen = !state.IsModalIngredienteOpen
    }




}
export default{
    state,
    mutations,
    getters,
    actions    
}