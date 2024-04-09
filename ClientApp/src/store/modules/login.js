export const login = 'login'

const state =  {
isLogado:false,

}
const getters = {
    getIsLogado: (state) => state.isLogado,

}


const actions = {
    setLogin({commit}){
      
        commit('login')   
       
    },
    logout({commit}){
         commit('logout')

    }
}

const mutations = {

    login(state){
        state.isLogado = true;
      
    },
    logout(state){
        state.isLogado = false;

    }
   
}
export default{
    state,
    mutations,
    getters,
    actions    
}