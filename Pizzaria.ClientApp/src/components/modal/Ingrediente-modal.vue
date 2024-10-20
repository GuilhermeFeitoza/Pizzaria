<template>
    <div id="myModal" class="modal" v-if="getModalIngredientesOptions.visible">
        <!-- Modal content -->
        <div class="modal-content">
            <span class="close" v-on:click="closeModal">&times;</span>
            <h1>{{ this.modaltitle }} Ingrediente</h1>
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
            modaltitle:"",
        };
    },
    methods: {
        ...mapActions("modal", ["toggleModalIngrediente"]),
        ...mapActions("ingredientes", ["addIngrediente", "getIngredienteById","updateIngrediente"]),
        closeModal() {
            this.toggleModalIngrediente();
        },
        async save() {
            let payload = {
                IdIngrediente: this.getSelectedIngrediente,
                Nome: this.nome,
                Descricao: "",
                Preco: this.preco,
                QtdCal: this.cal


            }
            if (this.getModalIngredientesOptions.action == 'insert') {
                if (await this.addIngrediente(payload)) {
                    alert("Inserido com sucesso!!")
                    this.toggleModalIngrediente();
                    return;
                }
                alert("Erro ao inserir!!")
            } else if (this.getModalIngredientesOptions.action == 'update') {
                if (await this.updateIngrediente(payload)) {
                    alert("Alterado com sucesso!!")
                    this.toggleModalIngrediente();
                    return;
                }
                alert("Erro ao alterar ingrediente!!")
            }

        }
    },
    computed: {
        ...mapGetters("modal", ["getModalIngredientesOptions"]),
        ...mapGetters("ingredientes", ["getSelectedIngrediente"]),
        visible() {
            return this.getModalIngredientesOptions.visible;
        }
    },
    watch: {
        async visible() {
            if (this.getModalIngredientesOptions.action == "update") {
                this.modaltitle = "Alterar";
                let ingrediente = await this.getIngredienteById(this.getSelectedIngrediente);
                this.nome = ingrediente.nome;
                this.preco = ingrediente.preco;
                this.cal = ingrediente.qtdCal;
            }
            else if (this.getModalIngredientesOptions.action == "insert") {
                this.modaltitle = "Cadastrar";
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