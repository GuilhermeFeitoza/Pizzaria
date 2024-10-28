export const funcionarios = 'funcionarios'
const urlBase = "https://localhost:5001";
const axios = require('axios');
const state = {
    funcionarios: null,
    selectedFuncionario: null,

};
const getters = {
    getFuncionarios: (state) => state.funcionarios,
    getSeletedFuncionario: (state) => state.selectedFuncionario,

};




const actions = {
    async requestFuncionarios({ commit }) {
        try {
            var response = await axios.get(urlBase + '/api/funcionarios')
            commit("setFuncionarios", response.data);

        } catch (error) {

            var funcionarios = [
                {
                    Id: 1,
                    Nome: 'Guilherme Dionizio',
                    Senha: '1234',
                    Usuario: 'guilhermeftz',
                    Ativo: 'S',
                    DataAdmissao: '2024-10-26',
                    DataNascimento: '2001-12-09'
                },
                {
                    Id: 2,
                    Nome: 'Bruno Almeida',
                    Senha: 'pass1234',
                    Usuario: 'bruno.almeida',
                    Ativo: 'N',
                    DataAdmissao: '2022-05-30',
                    DataNascimento: '1985-03-12'
                },
                {
                    Id: 3,
                    Nome: 'Carla Ferreira',
                    Senha: 'senha123',
                    Usuario: 'carla.ferreira',
                    Ativo: 'S',
                    DataAdmissao: '2021-09-05',
                    DataNascimento: '1992-11-08'
                },
                {
                    Id: 4,
                    Nome: 'Diego Santos',
                    Senha: '12345678',
                    Usuario: 'diego.santos',
                    Ativo: 'S',
                    DataAdmissao: '2020-12-20',
                    DataNascimento: '1988-04-19'
                },
                {
                    Id: 5,
                    Nome: 'Eduarda Lima',
                    Senha: 'eduarda123',
                    Usuario: 'eduarda.lima',
                    Ativo: 'N',
                    DataAdmissao: '2019-06-01',
                    DataNascimento: '1995-09-30'
                }

            ]
            commit("setFuncionarios", funcionarios);
            console.error(error)

        }

    },
    async deleteFuncionarioAction({ commit }, param) {
        try {
            var response = await axios.delete(urlBase + '/api/funcionarios/' + param);
            return true;
        } catch (error) {
            return false;
        }


    },

    async updateFuncionario({ commit }, payload) {

        try {

            console.log(payload, 'update');
            var response = await axios.put(urlBase + '/api/funcionarios', payload)
            return true;

        } catch (error) {
            console.log(error);
            return false;
        }




    },

    async getFuncionarioById({ commit }, id) {
        try {
            var response = await axios.get(urlBase + `/api/funcionarios/${id}`)
            console.log(response.data)
            return response.data;

        } catch (error) {
            console.error(error)

        }


    },


    async addFuncionario({ commit }, payload) {
        try {
            console.log(payload);
            var request = await axios.post(urlBase + '/api/funcionarios', payload)
            return true;
        } catch (error) {
            return false;
        }

    },
    setSeletedFuncionario({ commit }, param) {
        console.log(param)
        commit('setSeletedFuncionario', param)

    }

}

const mutations = {
    setFuncionarios(state, param) {
        state.funcionarios = param;


    },
    setSeletedFuncionario(state, param) {
        state.selectedFuncionario = param;

    }


};

export default {
    state,
    mutations,
    getters,
    actions
}