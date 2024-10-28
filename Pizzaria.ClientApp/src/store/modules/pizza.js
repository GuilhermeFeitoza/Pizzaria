export const pizza = 'pizza'
const urlBase = "https://localhost:5001";
const axios = require('axios');
const state = {
    pizzas: null,
    selectedpizza: null,
};
const getters = {
    getPizzas: (state) => state.pizzas,
    getSelectedpizza: (state) => state.selectedPizza

};

const actions = {
    async updatePizza({ commit }, param) {

        try {
            let payload = {
                IdPizza: param.IdPizza,
                Nome: param.Nome,
                Descricao: param.Descricao,
                Preco: param.Preco,
                QtdCal: param.QtdCal
            }
            var request = await axios.put(urlBase + '/api/Pizza', payload)
            return true;
        } catch (error) {
            return false;
        }

    },
    async getPizzaById({ commit }, id) {
        try {
            var response = await axios.get(urlBase + '/api/pizza/' + id)
            commit("setPizzas", response.data);
            return response.data;

        } catch (error) {
            console.error(error)
        }

    },

    async requestPizzas({ commit }) {
        try {
            var response = await axios.get(urlBase + '/api/pizza')
            commit("setPizzas", response.data);
            return response.data;

        } catch (error) {

            return [
                { IdPizza: 1,  Nome: "Pizza de Camarão", Preco: 10.00, QtdCal: 89 },
                { IdPizza: 2,  Nome: "Pizza de Calabresa", Preco: 10.00, QtdCal: 89 },
                { IdPizza: 3,  Nome: "Pizza de Cheedar", Preco: 10.00, QtdCal: 89 },
                { IdPizza: 4,  Nome: "Pizza de Catupiry", Preco: 10.00, QtdCal: 89 },
                { IdPizza: 5,  Nome: "Pizza de Cebola", Preco: 10.00, QtdCal: 89 },
                { IdPizza: 6,  Nome: "Pizza de Alho", Preco: 5.00, QtdCal: 89 },
                { IdPizza: 7,  Nome: "Pizza de Peperoni", Preco: 10.00, QtdCal: 89 },
                { IdPizza: 8,  Nome: "Pizza de Cream cheese", Preco: 10.00, QtdCal: 89 },

            ];
            console.error(error)
        }
    },
    setSelectedPizza({ commit }, id) {
        commit("setSelectedPizza", id);

    },
    async deletePizza({ commit }, param) {
        try {
            var response = await axios.delete(urlBase + '/api/Pizza/' + param);
            return true;
        } catch (error) {
            return false;
        }

    },
    async addPizza({ commit }, param) {
        try {
            console.log(param);
            var request = await axios.post(urlBase + '/api/Pizza', param)
            return true;
        } catch (error) {
            return false;
        }

    },
    setSeletedPizza({ commit }, param) {
        commit('setPizzas', param)

    }

}

const mutations = {
    setPizzas(state, param) {
        state.pizzas = param;
    },
    setSelectedPizza(state, param) {
        state.selectedPizza = param;

    }

};

export default {
    state,
    mutations,
    getters,
    actions
}