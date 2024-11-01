export const pedidos = 'pedidos';
const axios = require('axios');
const urlBase = "https://localhost:5001";
const state = {

}
const getters = {
}
const actions = {

    async cancelOrder({ commit }, id) {
        try {
            var response = await axios.put(urlBase + '/api/pedidos/cancelOrder/' + id)
            return response.data;

        } catch (error) {

            console.error(error)
            return [];

        }
    },
    async requestPedidos({ commit }) {
        try {
            var response = await axios.get(urlBase + '/api/pedidos')
            return response.data;

        } catch (error) {

            console.error(error)
            return [];

        }
    },
    async requestUltimosPedidos({ commit }, top) {
        try {
            var response = await axios.get(urlBase + '/api/pedidos/getLast?top=' + top)
            return response.data;

        } catch (error) {

            console.error(error)
            return [];

        }
    },

    async requestMaisPedidos({ commit }) {

        try {
            var response = await axios.get(urlBase + '/api/pedidos/getMostOrdered')
            return response.data;
        } catch (error) {

            console.error(error)
            return [];

        }

    }
}


const mutations = {


}

export default {
    state,
    mutations,
    getters,
    actions
}