<template>
    <div id="myModal" class="modal" v-if="getModalIngredientesOptions.visible">
        <!-- Modal content -->
        <div class="modal-content">
            <span class="close" v-on:click="closeModal">&times;</span>
            <h1>{{ this.title }} Ingrediente</h1>
            <div id="form">
                <div>
                    <label for="txtNome">*Nome:</label>
                    <input type="text" v-model="nome" />
                </div>
                <div>
                    <label for="txtPreco">*Preço:</label>
                    <input type="text" v-model="preco" />
                </div>
                <div>

                    <label for="txtCal">*Calorias:</label>
                    <input type="text" v-model="cal" />
                </div>
            </div>

            <div>
                <div class="buttonContainer">
                    <button class="buttonConfirm" @click="save">
                        Confirmar
                    </button>
                    <button class="buttonExit" @click="closeModal" style="padding-left: 20px">
                        Sair
                    </button>
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
            cal: 0,
        };
    },
    methods: {
        ...mapActions("modal", ["toggleModalIngrediente"]),
        ...mapActions("ingredientes", ["addIngrediente"]),
        closeModal() {
            this.toggleModalIngrediente();
        },
        async save() {
            if (this.getModalIngredientesOptions.action == 'insert') {
                let payload = {
                    Nome: this.nome,
                    Descricao: "",
                    Preco: this.preco,
                    QtdCal: this.cal


                }
                if (await this.addIngrediente(payload)) {
                    alert("Inserido com sucesso!!")
                    return;
                }

                alert("Erro ao inserir!!")
            }

        }
    },
    computed: {
        ...mapGetters("modal", ["getModalIngredientesOptions"]),
        title() {
            return this.getModalIngredientesOptions.action == "insert" ? "Cadastrar" : "Alterar"

        },
        visible() {
            return this.getModalIngredientesOptions.visible;
        }
    },
    watch: {
        visible() {
            if (this.getModalIngredientesOptions.action == "update") {

                this.getIngrediente();

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