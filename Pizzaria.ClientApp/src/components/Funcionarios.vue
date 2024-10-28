<template>
    <div>
        <div id="headerActions">
            <img src="../assets/icons/mais.png" @click="openInsertFuncionarioModal()">
            <img src="../assets/icons/lapis.png" v-show="funcionarioSelecionado != null"
                @click="openUpdateFuncionarioModal()">
            <img src="../assets/icons/lixo.png"  @click="deleteFuncionario()">
        </div>
        <Grid :dataSource="getFuncionarios" :id="'gridFuncionarios'" :selected-field="'selected'" :sortable="true"
            :filterable="true">
        </Grid>
        <input type="hidden" id="hdnTeste" />
    </div>
</template>

<script>
import { mapGetters, mapActions } from 'vuex';
import $ from "jquery";
export default {
    name: "funcionarios",
    methods: {


        ...mapActions('modal', ['toggleModalFuncionario']),
        ...mapActions('funcionarios', ['requestFuncionarios', 'setSeletedFuncionario', 'deleteFuncionarioAction'
        ]),
        onChangeFunc: function (e) {
            var rows = e.sender.select();
            var dataItem;
            rows.each(function (e) {
                var grid = $("#gridFuncionarios").data("kendoGrid");
                dataItem = grid.dataItem(rows);
            })
            this.funcionarioSelecionado = dataItem.Id;
            this.setSeletedFuncionario(dataItem.Id);

        },
        openInsertFuncionarioModal() {

            this.toggleModalFuncionario('insert');

        },
        openUpdateFuncionarioModal() {


            this.toggleModalFuncionario('update');

        },
        deleteFuncionario() {

           if(this.deleteFuncionarioAction(this.funcionarioSelecionado)){
            alert("Excluido com sucesso");
            return;
           }
           alert("Erro ao excluir funcionário");
        }
    },
    async mounted() {
        $("#gridFuncionarios").kendoGrid({
            columns: [
                { selectable: true, width: 40, },
                { field: "Id", title: "Id" },
                { field: "Nome", title: "Nome" },
                { field: "Usuario", title: "Usuario" },
                { field: "DataAdmissao", title: "Data de admissão" },
                { field: "DataNascimento", title: "Data de Nascimento" },
                { field: "Ativo", title: "Ativo" },
            ],
            change: this.onChangeFunc,

        });

        await this.requestFuncionarios();
    },
    computed: {
        ...mapGetters('funcionarios', ['getFuncionarios'])

    },//

    data() {

        return {
            funcionarioSelecionado: null,

        }
    }
}
</script>

<style></style>