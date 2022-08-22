<template>

    <div class="card-pedidos">
        <span>
         Terça-feira 20/05/2022 20:00

        </span>
        <span class="card-pedidos-type-text">
        DELIVERY
        <img class="icon-size detalhes-pedido" src="../../assets/icons/setabaixo.png">
        </span>
        <br>
        <br>
        <span class="card-pedidos-status-text">
          <img class="icon-size" :src="require(`@/assets/icons/${imgStatus}`)">  
          <span>Entregue</span>
        </span>
        <br>
        <span>
          R$50,00
        </span>
        

    
    </div>
 
</template>

<script>
export default {
props:{
    status:'E'

    },
computed:{
    imgStatus(){
        if(this.status=='E'){

            return 'check.png';

        }


    }



}
}
</script>

<style>

</style>