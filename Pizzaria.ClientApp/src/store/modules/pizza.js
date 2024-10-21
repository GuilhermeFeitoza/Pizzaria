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
            var request = await axios.put(urlBase + '/api/Pizzas', payload)
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
                { idPizza: 1, nome: "Camarão", preco: 10.00, qtdCal: 89 },
                { idPizza: 2, nome: "Calabresa", preco: 10.00, qtdCal: 89 },
                { idPizza: 3, nome: "Cheedar", preco: 10.00, qtdCal: 89 },
                { idPizza: 4, nome: "Catupiry", preco: 10.00, qtdCal: 89 },
                { idPizza: 5, nome: "Cebola", preco: 10.00, qtdCal: 89 },
                { idPizza: 6, nome: "Alho", preco: 5.00, qtdCal: 89 },
                { idPizza: 7, nome: "Peperoni", preco: 10.00, qtdCal: 89 },
                { idPizza: 8, nome: "Cream cheese", preco: 10.00, qtdCal: 89 },
                { idPizza: 9, nome: "Azeitona", preco: 10.00, qtdCal: 89 },
                { idPizza: 10, nome: "Mussarela", preco: 10.00, qtdCal: 89 },

            ];
            console.error(error)
        }
    },
    setSelectedPizza({ commit }, id) {
        commit("setSelectedPizza", id);

    },
    async deletePizza({ commit }, param) {
        try {
            var response = await axios.delete(urlBase + '/api/Pizzas/' + param);
            return true;
        } catch (error) {
            return false;
        }

    },
    async addPizza({ commit }, param) {
        try {
            let payload = {
                Nome : param.Nome,
                Preco : param.Preco,
                Tamanho: param.Tamanho,
            }
            console.log(payload);
            var request = await axios.post(urlBase + '/api/Pizzas', payload)
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