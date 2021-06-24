<template>
  <div id="myModal" class="modal" v-if="getIsModalFuncionarioOpen">

  <!-- Modal content -->
  <div class="modal-content">
    <span class="close" v-on:click = "closeModal">&times;</span>
    <h1>Cadastrar Funcionário </h1>
<div id="form">
<div>
    <label for="txtCliente">*Nome:</label>
    <input type="text" />
  </div>
  <div>
    <label for="txtCpf">*Usuário:</label>
    <input type="text" />
  </div>
   <div>
    <label for="txtEmail">*Senha:</label>
    <input type="text" />
  </div>
  <div>
    <label for="txtTelefone">*Data da Admissão:</label>
    <DatePicker/>
    </div>
  <div>
    <label for = "dtNasc">*Data de Nascimento</label>
    <DatePicker/>
  </div>
  <div>
    <div class="buttonContainer"> 
      <button class="buttonConfirm">Confirmar</button>
      <button class="buttonExit" @click="closeModal" style="padding-left:20px">Cancelar</button>
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
        ...mapActions('modal',['toggleModalFuncionario']),
        closeModal(){
        this.toggleModalFuncionario();


        }
    },
    computed:{
      ...mapGetters('modal',['getIsModalFuncionarioOpen'])
      

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
