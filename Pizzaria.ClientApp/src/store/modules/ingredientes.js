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
    async updateIngrediente({ commit }, param) {

        try {
            let payload = {
                IdIngrediente: param.IdIngrediente,
                Nome: param.Nome,
                Descricao: param.Descricao,
                Preco: param.Preco,
                QtdCal: param.QtdCal
            }
            var request = await axios.put(urlBase + '/api/Ingredientes', payload)
            return true;
        } catch (error) {
            return false;
        }

    },
    async getIngredienteById({ commit }, id) {
        try {
            var response = await axios.get(urlBase + '/api/ingredientes/' + id)
            commit("setIngredientes", response.data);
            return response.data;

        } catch (error) {
            console.error(error)
        }

    },

    async requestIngredientes({ commit }) {
        try {
            var response = await axios.get(urlBase + '/api/ingredientes')
            commit("setIngredientes", response.data);
            return response.data;

        } catch (error) {

            return [
                { idIngrediente: 1, nome: "Camarão", preco: 10.00, qtdCal: 89 },
                { idIngrediente: 2, nome: "Calabresa", preco: 10.00, qtdCal: 89 },
                { idIngrediente: 3, nome: "Cheedar", preco: 10.00, qtdCal: 89 },
                { idIngrediente: 4, nome: "Catupiry", preco: 10.00, qtdCal: 89 },
                { idIngrediente: 5, nome: "Cebola", preco: 10.00, qtdCal: 89 },
                { idIngrediente: 6, nome: "Alho", preco: 5.00, qtdCal: 89 },
                { idIngrediente: 7, nome: "Peperoni", preco: 10.00, qtdCal: 89 },
                { idIngrediente: 8, nome: "Cream cheese", preco: 10.00, qtdCal: 89 },
                { idIngrediente: 9, nome: "Azeitona", preco: 10.00, qtdCal: 89 },
                { idIngrediente: 10, nome: "Mussarela", preco: 10.00, qtdCal: 89 },

            ];
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
        state.selectedIngrediente = param;

    }

};

export default {
    state,
    mutations,
    getters,
    actions
}