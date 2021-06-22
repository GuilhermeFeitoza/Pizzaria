<template>
  <div id="myModal" class="modal" v-if="getIsModalClienteOpen">

  <!-- Modal content -->
  <div class="modal-content">
    <span class="close" v-on:click = "teste">&times;</span>
    <h1>Cadastrar cliente </h1>
<div id="form">
<div>
    <label for="txtCliente">*Nome:</label>
    <input type="text" />
  </div>
  <div>
    <label for="txtCpf">*CPF:</label>
    <input type="text" />
  </div>
   <div>
    <label for="txtEmail">*Email:</label>
    <input type="text" />
  </div>
  <div>
    <label for="txtTelefone">*Telefone:</label>
    <input type="text" />
  </div>
  <div>
    <label for = "dtNasc">*Data de Nascimento</label>
    <DatePicker/>
  </div>
  <div>
    <div class="buttonContainer"> 
      <button class="buttonConfirm">Cadastrar</button>
      <button class="buttonExit" style="padding-left:20px">Sair</button>
    </div>
  </div>
</div>
</div>
  </div>
</template>

<script>
import { mapActions,mapGetters } from "vuex";

export default {
  
    methods:{
        ...mapActions('modal',['toggleModalCliente']),
        teste(){
        this.toggleModalCliente();


        }
    },
    computed:{
      ...mapGetters('modal',['getIsModalClienteOpen'])
      

    }

}
</script>

<style scoped>
 input{
  margin: 10px;


  }
  #form{
     width: 100%;

  }
</style>>
