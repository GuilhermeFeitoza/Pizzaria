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
    async deleteFuncionarioAction({ commit }, param) {
        try {
            var response = await axios.delete(urlBase + '/api/funcionarios/' + param);
            return true;
        } catch (error) {
            return false;
        }
    

    },

    async updateFuncionario({ commit }, payload) {

        try {

            console.log(payload,'update');
            var response = await axios.put(urlBase + '/api/funcionarios', payload)
            return true;

        } catch (error) {
            console.log(error);
            return false;
        }




    },

    async getFuncionarioById({ commit }, id) {
        try {
            var response = await axios.get(urlBase + `/api/funcionarios/${id}`)
            console.log(response.data)
            return response.data;

        } catch (error) {
            console.error(error)

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
        console.log(param)
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