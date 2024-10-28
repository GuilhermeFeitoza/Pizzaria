<template>
  <div>
    <br />
    <div id="headerActions">
      <img src="../assets/icons/mais.png" @click="openModalAdd()" />

    </div>
    <div class="main-container">
      <h1 style="font-family: Calibri">Bebidas</h1>
      <div v-for="bebida in bebidas" :key="bebida.id" style="display: inline-flex; max-width: 80%; flex-wrap: wrap">
        <bebida-item :id="bebida.IdBebida" :nome="bebida.Nome" :preco="bebida.Preco"></bebida-item>
      </div>
    </div>
  </div>

</template>

<script>
import { mapActions, mapGetters } from 'vuex';
import bebidaItem from './partial/bebida-item.vue';
export default {
  data() {
    return {
      bebidas: [],
    };
  },
  computed: {
    ...mapGetters('bebidas', ["getModalBebidaOptions"]),
    visible() {

      return this. getModalBebidaOptions.visible;
    }

  },


  components: {
    bebidaItem
  }, computed: {

  },
  methods: {
    ...mapActions('modal', ['toggleModalBebida']),
    ...mapActions('bebidas', ['requestBebidas']),
    openModalAdd() {

      this.toggleModalBebida("insert");


    },



  },
  async mounted() {
    this.bebidas = await this.requestBebidas();
  }, watch: {
    async visible() {
      this.bebidas = await this.requestBebidas();
    }

  }
};

</script>

<style></style>