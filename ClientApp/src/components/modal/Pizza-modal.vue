<template>
  <div id="myModal" class="modal" v-if="getPizzaModalOpen">
    <!-- Modal content -->
    <div class="modal-content">
      <span class="close" v-on:click="closeModal">&times;</span>
      <h1>Cadastrar Pizza</h1>
      <div id="form">
        <div>
          <label for="txtNome">*Nome:</label>
          <input type="text" v-model="nome" />
        </div>
        <div>
          <label for="txtCpf">*Preço:</label>
          <input type="text" v-model="preco" />
        </div>
        <div>
          <label for="txtEmail">*Tamanho:</label>
          <div class="container">
            <label class="radio-inline">
              <input type="radio" name="a" value="P" />Pequena
            </label>
            <label class="radio-inline">
              <input type="radio" name="a" value="M" />Média
            </label>
            <label class="radio-inline">
              <input type="radio" name="a" value="G" />Grande
            </label>
          </div>
          <div>
            <label for="txtCpf">*Ingredientes:</label>
            <li style= "list-style-type: none;" v-for="item in items" v-bind:key="item.id">
              <label class="checkbox-inline">
                <input type="checkbox" name="a" value="G" />{{ item.nome }}
              </label>
            </li>
          </div>
          <div></div>
        </div>

        <div>
          <div class="buttonContainer">
            <button class="buttonConfirm" @click="toggleModalPizza">
              Confirmar
            </button>
            <button
              class="buttonExit"
              @click="closeModal"
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
      preco: 0,
      tamanho: "",
      items: [
        {id:1,nome:'Calabresa'},
        {id:2,nome:'Mussarela'}
        ],
    };
  },
  methods: {
    ...mapActions("modal", ["toggleModalPizza"]),
    closeModal() {
      this.toggleModalPizza();
    },
  },
  computed: {
    ...mapGetters("modal", ["getPizzaModalOpen"]),
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
