export const pedidos = 'pedidos';
const axios = require('axios');
const urlBase = "https://localhost:5001";
const state = {

}
const getters = {
}
const actions = {

    async requestPedidos({ commit }) {
        try {
            var response = await axios.get(urlBase + '/api/pedidos')
            return response.data;

        } catch (error) {

            console.error(error)
            return [];
       
        }
    },
}


const mutations = {


}

export default {
    state,
    mutations,
    getters,
    actions
}