<template>
  <div>
    <div id="headerActions">
      <img src="../assets/icons/mais.png" v-on:click="openModal" />
      <img src="../assets/icons/lapis.png" />
      <img src="../assets/icons/lixo.png" v-on:click="removerCliente" />
    </div>
    <Grid :dataSource="getClientes" :id="'grid'"> </Grid>
  </div>
</template>

<script>
import { mapActions, mapGetters } from "vuex";
import $ from "jquery";
export default {
  name: "clientes",
  methods: {
    ...mapActions("modal", ["toggleModalCliente"]),
    ...mapActions("cliente", ["requestClientes","deleteCliente","setSeletedCliente"]),
    
    onRowClick(event) {
      event.dataItem[this.clienteSelecionado] =
        !event.dataItem[this.clienteSelecionado];
    },
    async removerCliente(){

        await this.deleteCliente(this.clienteSelecionado);


    },
    openModal() {
      this.toggleModalCliente();
    },
  },
  computed: {
    ...mapGetters("cliente", ["getClientes"]),
  },
  async mounted() {
    $("#grid").kendoGrid({
      columns: [
        { selectable: true, width: 40 },
        { field: "IdCliente", title: "Id" },
        { field: "Nome", title: "Nome" },
        { field: "Cpf", title: "CPF" },
        { field: "Telefone", title: "Telefone" },
        { field: "Email", title: "Email" },
        { field: "Ativo", title: "Ativo" },
      ],
      change: function (e) {
        var rows = e.sender.select();
        rows.each(function (e) {
         
          var grid = $("#grid").data("kendoGrid");
      
          var dataItem = grid.dataItem(rows);
          
        
        
        
         
        })
      
       
      },
    });
    await this.requestClientes();
  },

  data() {
    return {
      clienteSelecionado: null,
    };
  },
};
</script>

<style>
</style>