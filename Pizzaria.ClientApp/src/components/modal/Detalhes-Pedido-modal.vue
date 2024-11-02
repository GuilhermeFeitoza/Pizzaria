<template>
    <div id="myModal" class="modal" v-if="getDetailsModalOpen">
        <!-- Modal content -->
        <div class="modal-content">
            <h1>Detalhes do pedido</h1>
            <div v-for="itemPedido in getDetalhesModalData.Pizzas">
                <span> 1 x {{ itemPedido.Nome }}</span> <br /><br />
            </div>
            <div v-for="itemPedidoBebida in getDetalhesModalData.Bebidas">
                <span> 1 x {{ itemPedidoBebida.Nome }}</span> <br /><br />
            </div>


            <div>
                <div class="buttonContainer">

                    <button class="buttonExit" @click="toggleModalDetalhes" style="padding-left: 20px">
                        Sair
                    </button>
                </div>
            </div>
        </div>
    </div>

</template>

<script>
import { map } from 'jquery';
import { mapActions, mapGetters } from 'vuex'
export default {
    data() {
        return {

        }

    },
    methods: {
        ...mapActions('pedidos', ["requestPedidoDetalhe"]),
        ...mapActions('modal', ["toggleModalDetalhes"])
    },
    computed: {
        ...mapGetters('modal', ['getDetailsModalOpen', 'getDetalhesModalData']),
    },
    watch: {
        getDetailsModalOpen() {
            if (this.getDetailsModalOpen) {

                console.log(this.getDetalhesModalData)
            }

        }

    }


}

</script>