export const bebida = 'bebida'
const urlBase = "https://localhost:5001";
const axios = require('axios');
const state = {
    bebidas: null,
    selectedBebida: null,
};
const getters = {
    getBebidas: (state) => state.bebidas,
    getSelectedBebida: (state) => state.selectedBebida

};

const actions = {
    async updateBebida({ commit }, param) {

        try {
            let payload = {
                IdBebida: param.IdBebida,
                Nome: param.Nome,
                Descricao: param.Descricao,
                Preco: param.Preco,
                QtdCal: param.QtdCal
            }
            var request = await axios.put(urlBase + '/api/Bebidas', payload)
            return true;
        } catch (error) {
            return false;
        }

    },
    async getBebidaById({ commit }, id) {
        try {
            var response = await axios.get(urlBase + '/api/bebidas/' + id)
            commit("setBebidas", response.data);
            return response.data;

        } catch (error) {
            console.error(error)
        }

    },

    async requestBebidas({ commit }) {
        try {
            var response = await axios.get(urlBase + '/api/bebidas')
            commit("setBebidas", response.data);
            return response.data;

        } catch (error) {

            return [
                { IdBebida: 10, img: "bebida.jpg", Nome: "Coca-Cola", Preco: 10.0 },
                { IdBebida: 12, img: "bebida.jpg", Nome: "Coca-Cola", Preco: 10.0 },
                { IdBebida: 13, img: "bebida.jpg", Nome: "Guaraná",   Preco: 10.0 },
                { IdBebida: 14, img: "bebida.jpg", Nome: "Pepsi",     Preco: 10.0 },
                { IdBebida: 15, img: "bebida.jpg", Nome: "Dolly",     Preco: 10.0 },

            ];
           console.error(error)
        }
    },
    setSelectedBebida({ commit }, id) {
        commit("setSelectedBebida", id);

    },
    async deleteBebida({ commit }, param) {
        try {
            var response = await axios.delete(urlBase + '/api/Bebidas/' + param);
            return true;
        } catch (error) {
            return false;
        }

    },
    async addBebida({ commit }, param) {
        try {
            let payload = {
                Nome: param.Nome,
                Descricao: param.Descricao,
                Preco: param.Preco,
                QtdCal: param.QtdCal
            }
            console.log(payload);
            var request = await axios.post(urlBase + '/api/Bebidas', payload)
            return true;
        } catch (error) {
            return false;
        }

    },
    setSeletedBebida({ commit }, param) {
        commit('setBebidas', param)

    }

}

const mutations = {
    setBebidas(state, param) {
        state.bebidas = param;
    },
    setSelectedBebida(state, param) {
        state.selectedBebida = param;

    }

};

export default {
    state,
    mutations,
    getters,
    actions
}