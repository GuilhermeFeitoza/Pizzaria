<template>
  <div>
    <div id="headerActions">
      <img src="../assets/icons/mais.png" v-on:click="openModal" />
      <img src="../assets/icons/lapis.png" @click="editarCliente"/>
      <img src="../assets/icons/lixo.png" @click="removerCliente" />
    </div>
    <Grid :dataSource="getClientes" :id="'gridClientes'" :selected-field="'selected'" :sortable="true"
      :filterable="true"> </Grid>
  </div>
</template>

<script>
import { mapActions, mapGetters } from "vuex";
import $ from "jquery";
export default {
  name: "clientes",
  methods: {
    ...mapActions("modal", ["toggleModalCliente"]),
    ...mapActions("cliente", ["requestClientes", "deleteCliente", "setSeletedCliente","getClienteById"]),
    onChangeFunc: function (e) {
      var rows = e.sender.select();
      var dataItem;
      rows.each(function (e) {
        var grid = $("#gridClientes").data("kendoGrid");
        dataItem = grid.dataItem(rows);
      })
      this.clienteSelecionado = dataItem.IdCliente;
      this.setSeletedCliente(dataItem.IdCliente);

    },

    onRowClick(event) {
      event.dataItem[this.clienteSelecionado] =
        !event.dataItem[this.clienteSelecionado];
    },
    async removerCliente() {
      await this.deleteCliente(this.clienteSelecionado);
    },
    openModal() {
      this.toggleModalCliente('insert');
    },
    editarCliente() {
      this.toggleModalCliente('update');
    },
  },
  computed: {
    ...mapGetters("cliente", ["getClientes"]),
  },
  async mounted() {
    $( document ).ready(
    $("#gridClientes").kendoGrid({
      columns: [
        { selectable: true, width: 40 },
        { field: "IdCliente", title: "Id" },
        { field: "Nome", title: "Nome" },
        { field: "Cpf", title: "CPF" },
        { field: "Telefone", title: "Telefone" },
        { field: "Email", title: "Email" },
        { field: "Ativo", title: "Ativo" },
      ],
      change: this.onChangeFunc

    })
  );
    await this.requestClientes();
  },

  data() {
    return {
      clienteSelecionado: null,
    };
  },
};
</script>

<style></style>