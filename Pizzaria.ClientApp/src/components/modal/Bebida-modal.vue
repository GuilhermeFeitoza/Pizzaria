<template>
    <div id="myModal" class="modal" v-if="getModalBebidaOptions.visible">
        <!-- Modal content -->
        <div class="modal-content">
            <span class="close" v-on:click="closeModal">&times;</span>
            <h1>{{ this.getModalBebidaOptions.action == "insert" ? "Cadastrar": "Alterar" }} Bebida</h1>
            <div id="form">
                <div>
                    <label for="txtNome">*Nome:</label>
                    <input type="text" v-model="nome" />
                </div>
                <div>
                    <label for="txtPreco">*Preço:</label>
                    <input type="text" v-model="preco" />
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
            id:0,
            nome: "",
            preco: 0,
            cal: 0,
            modaltitle:"",
        };
    },
    methods: {
        ...mapActions("modal", ["toggleModalBebida"]),
        ...mapActions("bebidas", ["addBebida", "getBebidaById","updateBebida"]),
        closeModal() {
            this.toggleModalBebida();
        },
        async save() {
            let payload = {
                IdBebida: this.getSelectedBebida,
                Nome: this.nome,
                Descricao: "",
                Preco: this.preco,
                QtdCal: this.cal


            }
            if (this.getModalBebidaOptions.action == 'insert') {
                if (await this.addBebida(payload)) {
                    alert("Inserido com sucesso!!")
                    this.toggleModalBebida();
                    return;
                }
                alert("Erro ao inserir!!")
            } else if (this.getModalBebidaOptions.action == 'update') {
                if (await this.updateBebida(payload)) {
                    alert("Alterado com sucesso!!")
                    this.toggleModalBebida();
                    return;
                }
                alert("Erro ao alterar bebida!!")
            }

        }
    },
    computed: {
        ...mapGetters("modal", ["getModalBebidaOptions"]),
        ...mapGetters("bebidas", ["getSelectedBebida"]),
        visible() {
            return this.getModalBebidaOptions.visible;
        }
    },
    watch: {
        async visible() {
            if (this.getModalBebidaOptions.action == "update") {
                this.modaltitle = "Alterar";
                let bebida = await this.getBebidaById(this.getSelectedBebida);
                this.id = bebida.IdBebida;
                this.nome = bebida.Nome;
                this.preco = bebida.Preco;
            }
            else if (this.getModalBebidaOptions.action == "insert") {
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