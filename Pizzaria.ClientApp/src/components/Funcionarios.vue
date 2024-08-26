<template>
    <div>
        <div id="headerActions">
            <img src="../assets/icons/mais.png" @click="openInsertFuncionarioModal()">
            <img src="../assets/icons/lapis.png" @click = "openUpdateFuncionarioModal()">
            <img src="../assets/icons/lixo.png" @click="deleteFuncionario()">
        </div>
        <Grid  :dataSource="getFuncionarios" :id="'gridFuncionarios'" :selectable="'multiple cell'"
            :sortable="true" :filterable="true" :groupable="true">

        </Grid>
    </div>
</template>

<script>
import { mapGetters, mapActions } from 'vuex';
import $ from "jquery";
export default {
    name: "funcionarios",
    methods: {
        
    onRowClick(event) {
      event.dataItem[this.funcionarioSelecionado] =
        !event.dataItem[this.funcionarioSelecionado];
    },
        ...mapActions('modal', ['toggleModalFuncionario']),
        ...mapActions('funcionarios', ['requestFuncionarios',  'setSeletedFuncionario'
        ]),
        onChange: function (ev) {
            var selected = $.map(ev.sender.select(), function (item) {
                return $(item).text();
            });

        },
        openInsertFuncionarioModal() {
            this.toggleModalFuncionario('insert');

        },
        openUpdateFuncionarioModal() {
            this.toggleModalFuncionario('update');

        },
        deleteFuncionario(){

           console.log("Deleted") ;
        }
    },
    async mounted() {
        await this.requestFuncionarios();
        $("#gridFuncionarios").kendoGrid({
            columns: [
                { selectable: true, width: 40 },
                { field: "IdFuncionario", title: "Id" },
                { field: "Nome", title: "Nome" },
                { field: "Usuario", title: "Usuario" },
                { field: "DataAdmissao", title: "Data de admissão" },
                { field: "DataNascimento", title: "Data de Nascimento" },
                { field: "Ativo", title: "Ativo" },
            ],
            change: function (e) {
                var rows = e.sender.select();
                var selected = null;
                rows.each(function (e) {
                    var grid = $("#gridFuncionarios").data("kendoGrid");
                    var dataItem = grid.dataItem(rows);
                    selected = dataItem;
 
                }).bind(this);
                this.setSeletedFuncionario(selected)
            },
        });


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