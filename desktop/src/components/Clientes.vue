<template>
  <div>
    <Grid :data-source="localDataSource"
                :selectable="'multiple cell'"
                :sortable="true"
                :filterable="true"
                :groupable="true"
             >
    </Grid>
  </div>
</template>

<script>
export default {
name:"clientes",
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