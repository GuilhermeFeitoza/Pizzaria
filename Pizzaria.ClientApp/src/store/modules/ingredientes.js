export const ingrediente = 'ingrediente'
const urlBase = "https://localhost:5001";
const axios = require('axios');
const state = {
    ingredientes: null,
    selectedIngrediente: null,
};
const getters = {
    getIngredientes: (state) => state.ingredientes,
    getSelectedIngrediente: (state) => state.selectedIngrediente

};

const actions = {
    async requestIngredientes({ commit }) {
        try {
            var response = await axios.get(urlBase + '/api/ingredientes')
            commit("setIngredientes", response.data);
            return response.data;

        } catch (error) {
            console.error(error)
        }
    },
    setSelectedIngrediente({ commit }, id) {
        commit("setSelectedIngrediente", id);

    },
    async deleteIngrediente({ commit }, param) {
        try {
            var response = await axios.delete(urlBase + '/api/Ingredientes/' + param);
            return true;
        } catch (error) {
            return false;
        }

    },
    async addIngrediente({ commit }, param) {
        try {
            let payload = {
                Nome: param.Nome,
                Descricao: param.Descricao,
                Preco: param.Preco,
                QtdCal: param.QtdCal
            }
            console.log(payload);
            var request = await axios.post(urlBase + '/api/Ingredientes', payload)
            return true;
        } catch (error) {
            return false;
        }

    },
    setSeletedIngrediente({ commit }, param) {
        commit('setIngredientes', param)

    }

}

const mutations = {
    setIngredientes(state, param) {
        state.ingredientes = param;
    },
    setSelectedIngrediente(state, param) {
        state.setSelectedIngrediente = param;

    }

};

export default {
    state,
    mutations,
    getters,
    actions
}