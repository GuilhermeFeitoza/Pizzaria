<template>
  <div>
    <div id="headerActions">
      <img src="../assets/icons/mais.png" v-on:click="openModal" />
      <img src="../assets/icons/lapis.png" />
      <img src="../assets/icons/lixo.png" />
    </div>
    <Grid
      :id="'grid'"
      :selectable="'multiple cell'"
      :sortable="true"
      :filterable="true"
     
    >
    </Grid>
  </div>
</template>

<script>
import { mapActions, mapGetters } from "vuex";
import $ from 'jquery';
export default {
  name: "clientes",
  methods: {
    ...mapActions("modal", ["toggleModalCliente"]),
    ...mapActions("cliente", ["requestClientes"]),
    openModal() {
      this.toggleModalCliente();
    },
    onChange: function (ev) {
      var selected = $.map(ev.sender.select(), function (item) {
        return $(item).text();
      });
    },
  },
  computed: {
    ...mapGetters("cliente", ["getClientes"]),
  },
  async mounted() {
    await this.requestClientes();
    $("#grid").kendoGrid({
      
      dataSource: this.getClientes,
    });
  },

  data() {
    return {};
  },
};
</script>

<style>
</style>