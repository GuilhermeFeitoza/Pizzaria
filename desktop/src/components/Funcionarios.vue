<template>
<div>
<div id ="headerActions"> 
       <img src="../assets/icons/mais.png">
      <img src="../assets/icons/lapis.png">
      <img src="../assets/icons/lixo.png">
     
      
  </div>
  <Grid 
                :selectable="'multiple cell'"
                :sortable="true"
                :filterable="true"
                :groupable="true">
                
</Grid>
</div>
</template>

<script>
export default {
name:"funcionarios",
methods: {
        onChange: function(ev) {
            var selected = $.map(ev.sender.select(), function(item) {
                return $(item).text();
            });

    }
},
    data() {
        return{

        }
    }
}
</script>

<style>

</style>