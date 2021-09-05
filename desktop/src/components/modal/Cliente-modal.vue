<template>
  <div id="myModal" class="modal" v-if="getIsModalClienteOpen">
    <!-- Modal content -->
    <div class="modal-content">
      <span class="close" v-on:click="closeModal">&times;</span>
      <h1>Cadastrar cliente</h1>
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
            <button class="buttonConfirm" @click="cadastrarCliente">
              Confirmar
            </button>
            <button
              class="buttonExit"
              @click="cancelar"
              style="padding-left: 20px"
            >
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
    ...mapActions("cliente", ["addCliente"]),
    closeModal() {
      this.toggleModalCliente();
    },
    cadastrarCliente() {
      let payload = {
        Nome: this.nome,
        Cpf: this.cpf,
        Email: this.email,
        Telefone: this.telefone,
        DataNascimento: this.data,
        Ativo: this.ativo,
      };
      console.log(payload);
      this.addCliente(payload);
      this.toggleModalCliente();
    },
    cancelar() {
      this.toggleModalCliente();
    },
  },
  computed: {
    ...mapGetters("modal", ["getIsModalClienteOpen"]),
  },
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
