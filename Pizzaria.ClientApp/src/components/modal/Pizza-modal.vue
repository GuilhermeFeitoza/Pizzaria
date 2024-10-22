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
              <input type="radio" name="a" value=4 />Pequena
            </label>
            <label class="radio-inline">
              <input type="radio" name="a" value=8 />Padrão
            </label>
            <label class="radio-inline">
              <input type="radio" name="a" value=12 />Grande
            </label>
          </div>
          <div>
            <label for="txtCpf">*Ingredientes:</label>
            <li style="list-style-type: none;" v-for="item in items" v-bind:key="item.idIngrediente">
              <label class="checkbox-inline">
                <input type="checkbox" name="a" :value="item.idIngrediente" @change="onChange($event)" />{{ item.nome }}
              </label>
            </li>
          </div>
          <div></div>
        </div>

        <div>
          <div class="buttonContainer">
            <button class="buttonConfirm" @click="cadastrarPizza">
              Confirmar
            </button>
            <button class="buttonExit" @click="closeModal" style="padding-left: 20px">
              Sair
            </button>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { event } from "jquery";
import { mapActions, mapGetters } from "vuex";

export default {
  data() {
    return {
      nome: "",
      preco: 0,
      tamanho: 8,
      items: [],
      selectedIngredientes: []

    };
  },
  methods: {
    ...mapActions("modal", ["toggleModalPizza"]),
    ...mapActions("ingredientes", ["requestIngredientes"]),
    ...mapActions("pizzas", ["addPizza"]),
    closeModal() {
      this.toggleModalPizza();
    },
    onChange(e) {

      let idIngrediente = e.target.value;
      if (e.target.checked) {
        this.selectedIngredientes.push(idIngrediente)
      } else {
        const index = this.selectedIngredientes.indexOf(idIngrediente);
        if (index > -1) { // only splice array when item is found
          this.selectedIngredientes.splice(index, 1); // 2nd parameter means remove one item only
        }

      }

    },
    cadastrarPizza() {

      let payload = {
        Nome: this.nome,
        Preco: this.preco,
        Tamanho: this.tamanho,
        Ingredientes: this.selectedIngredientes

      };

      this.addPizza(payload);
    }

  },
  watch: {
    async getPizzaModalOpen() {
      this.items = await this.requestIngredientes();
    }
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
