export const funcionarios = 'funcionarios'
const urlBase = "https://localhost:5001";
const axios = require('axios');
const state = {
    funcionarios: null,
    selectedFuncionario: null,

};
const getters = {
    getFuncionarios: (state) => state.funcionarios,
    getSeletedFuncionario: (state) => state.selectedFuncionario,

};




const actions = {
    async requestFuncionarios({ commit }) {
        try {
            var response = await axios.get(urlBase + '/api/funcionarios')

            commit("setFuncionarios", response.data);

        } catch (error) {
            console.error(error)

        }

    },
    async deleteFuncionario({ commit }, param) {
        console.log('IDFuncionario', param)
        var response = await axios.delete(urlBase + '/api/funcionarios/' + param);
        console.log(response);


    },
    
    async updateFuncionario({commit},payload){

            try {

                console.log(payload);
                var response = await axios.put(urlBase + '/api/funcionarios/' + payload.id , payload)
        
            } catch (error) {
               console.log(error);
            }
      



    },


    async addFuncionario({ commit }, payload) {
        try {
            console.log(payload);
            var request = await axios.post(urlBase + '/api/funcionarios', payload)
            return true;
        } catch (error) {
            return false;
        }

    },
    setSeletedFuncionario({ commit }, param) {
        commit('setSeletedFuncionario', param)

    }

}

const mutations = {
    setFuncionarios(state, param) {
        state.funcionarios = param;


    },
    setSeletedFuncionario(state, param) {
        state.selectedFuncionario = param;

    }


};

export default {
    state,
    mutations,
    getters,
    actions
}