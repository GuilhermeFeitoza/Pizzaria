<template>
  <div id="myModal" class="modal" v-if="getModalFuncionarioOptions.visible">

    <!-- Modal content -->
    <div class="modal-content">
      <span class="close" v-on:click="closeModal">&times;</span>
      <h1>{{ this.modaltitle }} </h1>
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
            <button class="buttonConfirm" @click="confirmarFuncionarioButton">Confirmar</button>
            <button class="buttonExit" @click="closeModal" style="padding-left:20px">Cancelar</button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { mapActions, mapGetters } from "vuex";
import modal from "../../store/modules/modal";



export default {
  data: function () {
    return {
      nome: "",
      usuario: "",
      senha: "",
      cpf: "",
      telefone: "",
      email: "",
      dtAdmissao: null,
      dtNascimento: null,
      modalAction: 0,
      modaltitle: ""
    }
  },
  methods: {
    ...mapActions('modal', ['toggleModalFuncionario']),
    ...mapActions('funcionarios', ['addFuncionario', 'updateFuncionario', 'getFuncionarioById']),
    closeModal() {
      this.toggleModalFuncionario();
    },
    async confirmarFuncionarioButton() {
      let payload = {
        IdFunc: this.getSeletedFuncionario,
        Nome: this.nome,
        Cpf: this.cpf,
        Usuario: this.usuario,
        Senha: this.senha,
        Email: this.email,
        DataNascimento: this.dtAdmissao,
        DataAdmissao: this.dtNascimento,
        Ativo: "S",
      }
      if (this.getModalFuncionarioOptions.action == 'insert') {
        try {
          if (await this.addFuncionario(payload)) {
            this.toggleModalFuncionario();
            window.alert("Funcionário cadastrado com sucesso");

          } else {
            window.alert("Erro ao cadastrar");
          }

        } catch (error) {
          window.alert("erro");

        }
      } else if (this.getModalFuncionarioOptions.action == 'update') {
        if (this.updateFuncionario(payload)) {
          window.alert("Funcionário alterado com sucesso");
          this.toggleModalFuncionario();
        } else {

          window.alert("Erro ao cadastrar");
        }
      }

    }
  },
  computed: {
    ...mapGetters('modal', ['getModalFuncionarioOptions']),
    ...mapGetters('funcionarios', ['getSeletedFuncionario']),
    visible() {
      return this.getModalFuncionarioOptions.visible;
    }
  },
  watch: {

    async visible() {
      if (this.getModalFuncionarioOptions.visible) {
        if (this.getModalFuncionarioOptions.action.toLowerCase() == 'insert') {

          this.modaltitle = "Cadastrar funcionário";
        }
        else if (this.getModalFuncionarioOptions.action.toLowerCase() == 'update') {
          this.modaltitle = "Alterar funcionário";
          if (this.getSeletedFuncionario != null) {
            let funcionario = await this.getFuncionarioById(this.getSeletedFuncionario);
            this.nome = funcionario.Nome
            this.usuario = funcionario.Usuario
            this.senha = funcionario.Senha
            this.cpf = funcionario.Cpf
            this.telefone = funcionario.Telefone
            this.email = funcionario.Email
            this.dtAdmissao = funcionario.DataAdmissao
            this.dtNascimento = funcionario.DataNascimento
          }

        }
        else if (this.getModalFuncionarioOptions.action.toLowerCase() == 'view') {

          this.modaltitle = "Consultar funcionário";
        }
      }
    }




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
