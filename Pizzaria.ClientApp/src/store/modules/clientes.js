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
            commit("setClientes", JSON.parse(JSON.stringify([
                { IdCliente: 1, Nome: "Claudio", Cpf: '456.333.444.55', DataNascimento: '1990-09-20', Telefone: '1234-5678', Email: 'claudio@example.com', Ativo: 'S' },
                { IdCliente: 2, Nome: "Roberto", Cpf: '567.333.444.51', DataNascimento: '1980-09-20', Telefone: '2345-6789', Email: 'roberto@example.com', Ativo: 'N' },
                { IdCliente: 3, Nome: "Tomas", Cpf: '234.333.444.52', DataNascimento: '1990-09-20', Telefone: '3456-7890', Email: 'tomas@example.com', Ativo: 'S' },
                { IdCliente: 4, Nome: "João", Cpf: '343.484.444.53', DataNascimento: '2001-09-20', Telefone: '4567-8901', Email: 'joao@example.com', Ativo: 'S' },
                { IdCliente: 5, Nome: "Marina", Cpf: '456.333.444.55', DataNascimento: '2010-02-20', Telefone: '5678-9012', Email: 'marina@example.com', Ativo: 'N' },
                { IdCliente: 6, Nome: "Rihanna", Cpf: '456.333.444.55', DataNascimento: '2000-03-20', Telefone: '6789-0123', Email: 'rihanna@example.com', Ativo: 'S' },
                { IdCliente: 7, Nome: "Beyonce", Cpf: '456.333.444.55', DataNascimento: '2006-04-20', Telefone: '7890-1234', Email: 'beyonce@example.com', Ativo: 'S' },
                { IdCliente: 8, Nome: "Vladimir", Cpf: '456.333.444.55', DataNascimento: '2002-05-20', Telefone: '8901-2345', Email: 'vladimir@example.com', Ativo: 'N' },
                { IdCliente: 9, Nome: "Pitagoras", Cpf: '456.333.444.55', DataNascimento: '2004-09-20', Telefone: '9012-3456', Email: 'pitagoras@example.com', Ativo: 'S' }
            ]  )));

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
                IdCliente: param.IdCliente,
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
            var request = await axios.get(urlBase + '/api/clientes/' + id)
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