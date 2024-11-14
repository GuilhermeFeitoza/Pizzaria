export const avaliacao = 'avaliacao'
const urlBase = "https://localhost:5001";
const axios = require('axios');
const state = {
    avaliacoes: null,
    selectedAvaliacao: null,
};
const getters = {
    getAvaliacoes: (state) => state.avaliacoes,
    getSelectedAvaliacao: (state) => state.selectedAvaliacao

};

const actions = {
    async updateAvaliacao({ commit }, param) {

        try {
            let payload = {
                IdAvaliacao: param.IdAvaliacao,
                Nome: param.Nome,
                Descricao: param.Descricao,
                Preco: param.Preco,
                QtdCal: param.QtdCal
            }
            var request = await axios.put(urlBase + '/api/Avaliacoes', payload)
            return true;
        } catch (error) {
            return false;
        }

    },
    async getAvaliacaoById({ commit }, id) {
        try {
            var response = await axios.get(urlBase + '/api/avaliacoes/' + id)
            commit("setAvaliacoes", response.data);
            return response.data;

        } catch (error) {
            console.error(error)
        }

    },

    async requestAvaliacoes({ commit }) {
        try {
            var response = await axios.get(urlBase + '/api/avaliacoes')
            commit("setAvaliacoes", response.data);
            return response.data;

        } catch (error) {

            return [


            ];
            console.error(error)
        }
    },
    setSelectedAvaliacao({ commit }, id) {
        commit("setSelectedAvaliacao", id);

    },
    async deleteAvaliacao({ commit }, param) {
        try {
            var response = await axios.delete(urlBase + '/api/Avaliacoes/' + param);
            return true;
        } catch (error) {
            return false;
        }

    },
    async addAvaliacao({ commit }, param) {
        try {
            let payload = {
                Nome: param.Nome,
                Descricao: param.Descricao,
                Preco: param.Preco,
                QtdCal: param.QtdCal
            }
            console.log(payload);
            var request = await axios.post(urlBase + '/api/Avaliacoes', payload)
            return true;
        } catch (error) {
            return false;
        }

    },
    setSeletedAvaliacao({ commit }, param) {
        commit('setAvaliacoes', param)

    }

}

const mutations = {
    setAvaliacoes(state, param) {
        state.avaliacoes = param;
    },
    setSelectedAvaliacao(state, param) {
        state.selectedAvaliacao = param;

    }

};

export default {
    state,
    mutations,
    getters,
    actions
}