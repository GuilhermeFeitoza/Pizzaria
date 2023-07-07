<template>
<div>
<div id ="headerActions"> 
       <img src="../assets/icons/mais.png" @click="openModal()">
      <img src="../assets/icons/lapis.png">
      <img src="../assets/icons/lixo.png">
     
      
  </div>
  <Grid 
                :dataSource="getFuncionarios" :id="'grid'"
                :selectable="'multiple cell'"
                :sortable="true"
                :filterable="true"
                :groupable="true">
                
</Grid>
</div>
</template>

<script>
import {mapGetters,mapActions} from 'vuex'
export default {
name:"funcionarios",
methods: {
    ...mapActions('modal',['toggleModalFuncionario']),
    ...mapActions('funcionarios',['requestFuncionarios']),
        onChange: function(ev) {
            var selected = $.map(ev.sender.select(), function(item) {
                return $(item).text();
            });

    },
    openModal(){
this.toggleModalFuncionario();

    }
},
async mounted(){
 await this.requestFuncionarios();

},
computed:{
...mapGetters('funcionarios',['getFuncionarios'])

},//

    data() {
        return{
         

        }
    }
}
</script>

<style>

</style>