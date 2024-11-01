<template>
    <div id="myModal" class="modal" v-if="getDetailsModalOpen">
        <!-- Modal content -->
        <div class="modal-content">
            <h1>Detalhes do pedido</h1>
            <div v-for="item in this.getItensPedido" v-bind:key="item.id">
                <span> 1 x {{ item.nome }}</span> <br /><br />
            </div>

            <span class="close" v-on:click="toggleModalResumo">&times;</span>
            <div>
                <div class="buttonContainer">
                    
                    <button class="buttonExit" @click="toggleModalResumo" style="padding-left: 20px">
                        Sair
                    </button>
                </div>
            </div>
        </div>
    </div>
</template>