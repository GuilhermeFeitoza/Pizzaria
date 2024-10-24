<template>
  <div id="myModal" class="modal" v-if="getModalClienteOptions.visible">
    <!-- Modal content -->
    <div class="modal-content">
      <span class="close" v-on:click="closeModal">&times;</span>
      <h1>{{ this.title }} cliente</h1>
      <div id="form">
        <div>
          <label for="txtCliente">*Nome:</label>
          <input type="text" v-model="nome" />
        </div>
        <div>
          <label for="txtCpf">*CPF:</label>
          <input type="text" v-model="cpf" />
        </div>
        <div>
          <label for="txtEmail">*Email:</label>
          <input type="text" v-model="email" />
        </div>
        <div>
          <label for="txtTelefone">*Telefone:</label>
          <input type="text" v-model="telefone" />
        </div>
        <div>
          <label for="dtNasc">*Data de Nascimento</label>
          <input type="date" v-model="data" />
        </div>
        <div>
          <div class="buttonContainer">
            <button class="buttonConfirm" @click="confirmButton">
              Confirmar
            </button>
            <button class="buttonExit" @click="cancelar" style="padding-left: 20px">
              Sair
            </button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { mapActions, mapGetters } from "vuex";

export default {
  data() {
    return {
      nome: "",
      cpf: "",
      email: "",
      telefone: "",
      data: "",
      ativo: "S",
    };
  },

  methods: {
    ...mapActions("modal", ["toggleModalCliente"]),
    ...mapActions("cliente", ["addCliente", "getClienteById", "update"]),
    closeModal() {
      this.toggleModalCliente();
    },
    confirmButton() {

      if (this.getModalClienteOptions.action == 'insert') {
        this.cadastrarCliente();

      } else {
        this.alterarCliente();
      }
    },
    async alterarCliente() {
      let payload = {
        IdCliente: this.getSeletedCliente,
        Nome: this.nome,
        Cpf: this.cpf,
        Email: this.email,
        Telefone: this.telefone,
        DataNascimento: this.data,
        Ativo: this.ativo,
      };
      await this.update(payload);

      this.toggleModalCliente();
    },

    async cadastrarCliente() {
      let payload = {
        Nome: this.nome,
        Cpf: this.cpf,
        Email: this.email,
        Telefone: this.telefone,
        DataNascimento: this.data,
        Ativo: this.ativo,
      };
      await this.addCliente(payload);
      this.toggleModalCliente();
    },
    cancelar() {
      this.toggleModalCliente();
    },
  },
  computed: {
    ...mapGetters("modal", ["getModalClienteOptions"]),
    ...mapGetters("cliente", ["getSeletedCliente"]),
    visible() {
      return this.getModalClienteOptions.visible;
    }
  },
  watch: {

    async visible() {
      if (this.getModalClienteOptions.action == "insert") {
        this.title = "Cadastrar"
      } else {
        this.title = "Alterar"
        console.log(this.getSeletedCliente)
        var cliente = await this.getClienteById(this.getSeletedCliente);
        this.nome = cliente.Nome
        this.cpf = cliente.Cpf
        this.email = cliente.Email
        this.telefone = cliente.Telefone
        this.data = cliente.Data
        this.ativo = cliente.Ativo

      }

    }

  }
};
</script>

<style scoped>
input {
  margin: 10px;
}

#form {
  width: 100%;
}
</style>>
