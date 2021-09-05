export const clientes = 'clientes'
const urlBase = "https://localhost:5001";
const axios = require('axios');
const state = {
    clientes: null,

};
const getters = {
    getClientes: (state) => state.clientes,

};




const actions = {
   async requestClientes({ commit }) {
        try {
           var response = await axios.get(urlBase + '/api/clientes')
            console.log(response.data);
            commit("setClientes",response.data);

        } catch (error) {
            console.error(error)

        }

    },
    async addCliente({ commit },param) {
        try {
           
            let payload = {
                Nome:param.Nome,
                Cpf:param.Cpf,
                Telefone:param.Telefone,
                Email:param.Email,
                DataNascimento:param.DataNascimento,
               


            }
           var request = await axios.post(urlBase + '/api/clientes',payload)
      
        
        } catch (error) {
            console.error(error)

        }

    }


}

const mutations = {
    setClientes(state,param){
        state.clientes = param;
        console.log('entrei')

    }


};

export default {
    state,
    mutations,
    getters,
    actions
}