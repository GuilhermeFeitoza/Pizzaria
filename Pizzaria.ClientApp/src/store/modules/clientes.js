export const clientes = 'clientes'
const urlBase = "https://localhost:5001";
const axios = require('axios');
const state = {
    clientes: [],
    selectedCliente: null,

};
const getters = {
    getClientes: (state) => state.clientes,
    getSeletedCliente: (state) => state.selectedCliente,

};




const actions = {
    async requestClientes({ commit }) {
        try {
            var response = await axios.get(urlBase + '/api/clientes')
            var jsonResponse = JSON.parse(JSON.stringify(response.data));
            commit("setClientes", Array.from(jsonResponse));

        } catch (error) {
            console.error(error)

        }

    },
    async deleteCliente({ commit }, param) {
        console.log('IDCliente', param)
        var response = await axios.delete(urlBase + '/api/clientes/' + param);
        console.log(response);


    },
    async addCliente({ commit }, param) {
        try {

            let payload = {
                Nome: param.Nome,
                Cpf: param.Cpf,
                Telefone: param.Telefone,
                Email: param.Email,
                DataNascimento: param.DataNascimento,
                Ativo: "S"


            }
            console.log(payload);
            var request = await axios.post(urlBase + '/api/clientes', payload)


        } catch (error) {
            console.error(error)

        }

    },
    async update({ commit }, param) {
        try {

            let payload = {
                IdCliente:param.IdCliente,
                Nome: param.Nome,
                Cpf: param.Cpf,
                Telefone: param.Telefone,
                Email: param.Email,
                DataNascimento: param.DataNascimento,
                Ativo: "S"

            }
            var request = await axios.put(urlBase + '/api/clientes', payload)


        } catch (error) {
            console.error(error)

        }

    },

    async getClienteById({ commit }, id) {

        try {
            var request = await axios.get(urlBase + '/api/clientes/' +  id)
            return request.data;
        } catch (error) {
            console.error(error)

        }
    },
    setSeletedCliente({ commit }, param) {
        commit('setSeletedCliente', param)

    }

}

const mutations = {
    setClientes(state, param) {
        state.clientes = param;


    },
    setSeletedCliente(state, param) {
        state.selectedCliente = param;

    }


};

export default {
    state,
    mutations,
    getters,
    actions
}