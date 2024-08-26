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
      dtAdmissao: "",
      dtNascimento: "",
      modalAction: 0,
      modaltitle: ""
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
        if (await this.addFuncionario(payload)) {
          this.toggleModalFuncionario();
          // app.$toast.open({
          //   message: 'Cadastrado com sucesso',
          //   type: 'error',
          //   // all of other options may go here
          // });

        } else {

          // app.$toast.open({
          //   message: 'Something went wrong!',
          //   type: 'error',
          //   // all of other options may go here
          // });

        }

      } catch (error) {
        window.alert("erro");

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

    visible() {

      if (this.getModalFuncionarioOptions.action.toLowerCase() == 'insert') {

        this.modaltitle = "Cadastrar funcionário";
      }
      else if (this.getModalFuncionarioOptions.action.toLowerCase() == 'update') {
        console.log(this.getSeletedFuncionario);
        this.modaltitle = "Alterar funcionário";
        if (this.getSeletedFuncionario != null) {
          this.nome = this.getSeletedFuncionario.nome;
          this.usuario = this.getSeletedFuncionario.usuario;
          this.senha = this.getSeletedFuncionario.senha;
          this.cpf = this.getSeletedFuncionario.cpf;
          this.telefone = this.getSeletedFuncionario.telefone;
          this.email = this.getSeletedFuncionario.email;
          this.dtAdmissao = this.getSeletedFuncionario.dtAdmissao;
          this.dtNascimento = this.getSeletedFuncionario.dtNascimento;
        
        }

      }
      else if (this.getModalFuncionarioOptions.action.toLowerCase() == 'view') {

        this.modaltitle = "Consultar funcionário";
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
