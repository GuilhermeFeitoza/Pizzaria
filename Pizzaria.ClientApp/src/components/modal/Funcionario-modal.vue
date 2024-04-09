<template>
  <div id="myModal" class="modal" v-if="getIsModalFuncionarioOpen">

    <!-- Modal content -->
    <div class="modal-content">
      <span class="close" v-on:click="closeModal">&times;</span>
      <h1>Cadastrar Funcionário </h1>
      <div id="form">
        <div>
          <label for="txtCliente">*Nome:</label>
          <input v-model="nome" type="text" />
        </div>
        <div>
          <label for="txtCpf">*Usuário:</label>
          <input v-model="usuario" type="text" />
        </div>
        <div>
          <label for="txtEmail">*Senha:</label>
          <input v-model="email" type="text" />
        </div>
        <div>
          <label for="txtTelefone">*Data da Admissão:</label>
          <input type="date" v-model="dtAdmissao" />
        </div>
        <div>
          <label for="dtNasc">*Data de Nascimento</label>
          <input type="date" v-model="dtNascimento" />
        </div>
        <div>
          <div class="buttonContainer">
            <button class="buttonConfirm" @click="addFuncionarioButton">Confirmar</button>
            <button class="buttonExit" @click="closeModal" style="padding-left:20px">Cancelar</button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { mapActions, mapGetters } from "vuex";

export default {
  data: function () {
    return {
      nome: "",
      usuario: "",
      senha: "",
      cpf: "",
      telefone: "",
      email: "",
      dtAdmissao: "",
      dtNascimento: "",
    }
  },
  methods: {
    ...mapActions('modal', ['toggleModalFuncionario']),
    ...mapActions('funcionarios', ['addFuncionario']),
    closeModal() {
      this.toggleModalFuncionario();


    },
    async addFuncionarioButton() {

      try {
        let payload = {
          Nome: this.nome,
          Cpf: this.cpf,
          Usuario: this.usuario,
          Senha: this.senha,
          Email: this.email,
          DataNascimento: this.dtNascimento,
          DataAdmissao: this.dtAdmissao,
          Ativo: "S"
        }
        console.dir(payload);
        await this.addFuncionario(payload);
        this.toggleModalFuncionario();

      } catch (error) {
        window.alert("erro");

      }

    }
  },
  computed: {
    ...mapGetters('modal', ['getIsModalFuncionarioOpen'])


  }

}
</script>

<style scoped>
input {
  margin: 10px;


}

#form {
  width: 100%;

}
</style>>
