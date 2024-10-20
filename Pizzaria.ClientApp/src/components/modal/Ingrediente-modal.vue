<template>
    <div id="myModal" class="modal" v-if="getIngredienteModalIsOpen">
        <!-- Modal content -->
        <div class="modal-content">
            <span class="close" v-on:click="closeModal">&times;</span>
            <h1>Cadastrar Ingrediente</h1>
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
                    <button class="buttonConfirm" @click="toggleModalIngrediente">
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

        };
    },
    methods: {
        ...mapActions("modal", ["toggleModalIngrediente"]),
        closeModal() {
            this.toggleModalIngrediente();
        },
    },
    computed: {
        ...mapGetters("modal", ["getIngredienteModalIsOpen"]),
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