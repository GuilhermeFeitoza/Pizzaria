<template>
  <div id="myModal" class="modal" v-if="getPizzaModalOptions.visible">
    <!-- Modal content -->
    <div class="modal-content">
      <span class="close" v-on:click="closeModal">&times;</span>
      <h1>{{ this.title }} Pizza</h1>
      <div id="form">
        <div>
          <label for="txtNome">*Nome:</label>
          <input type="text" v-model="nome" />
        </div>
        <div>
          <label for="txtPreco">*Preço:</label>
          <input type="number" v-model="preco" />
        </div>
        <div>
          <label for="a">*Tamanho:</label>
          <div class="container">
            <label class="radio-inline">
              <input type="radio" name="a" v-model="tamanho" value=4 />Pequena
            </label>
            <label class="radio-inline">
              <input type="radio" name="a" v-model="tamanho" value=8 />Padrão
            </label>
            <label class="radio-inline">
              <input type="radio" name="a" v-model="tamanho" value=12 />Grande
            </label>
          </div>
          <div>
            <label for="txtCpf">*Ingredientes:</label>
            <li style="list-style-type: none;" v-for="item in items" v-bind:key="item.idIngrediente">
              <label class="checkbox-inline">
                <input type="checkbox" name="a" :data-nome="item.nome" :value="item.idIngrediente"
                  @change="onChange($event)" />{{ item.nome }}
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
      title: "Cadastrar",
      nome: "",
      preco: 0,
      tamanho: 8,
      items: [],
      selectedIngredientes: [],
      selectedIngredientesUpdate: []


    };
  },
  computed: {
    ...mapGetters("modal", ["getPizzaModalOptions"]),
    ...mapGetters("pizzas", ["getSelectedpizza"]),
    visible() {
      return this.getPizzaModalOptions.visible;
    }
  },

  methods: {
    ...mapActions("modal", ["toggleModalPizza"]),
    ...mapActions("ingredientes", ["requestIngredientes"]),
    ...mapActions("pizzas", ["addPizza", 'getPizzaById']),
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
    },
    marcarCheckboxes() {
      this.$nextTick(() => {
        this.items.forEach(item => {
          const checkbox = document.querySelector(`input[type="checkbox"][data-nome="${item.nome}"]`);
          if (checkbox) {
            checkbox.checked = this.selectedIngredientesUpdate.includes(item.nome); // Verifica se o nome do ingrediente está selecionado
          }
        });
      });
    }
  },

  watch: {
    async visible() {
      this.items = await this.requestIngredientes();
      if (this.getPizzaModalOptions.action == 'insert') {
        this.title = "Cadastrar";
      }
      else {
        var pizza = await this.getPizzaById(this.getSelectedpizza);
        this.nome = pizza.Nome;
        this.preco = pizza.Preco;
        this.tamanho = pizza.Tamanho;
        this.selectedIngredientesUpdate = pizza.Ingredientes
        this.title = "Alterar";
        this.marcarCheckboxes();

      }

    }
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
