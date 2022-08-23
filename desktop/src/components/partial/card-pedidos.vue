<template>

    <div class="card-pedidos">
        <span>
         Terça-feira 20/05/2022 20:00

        </span>
        <span class="card-pedidos-type-text">
        DELIVERY
        <img class="icon-size detalhes-pedido" @click="toggleMoreDetails" src="../../assets/icons/setabaixo.png">
        </span>
        <br>
        <br>
        <span class="card-pedidos-status-text">
          <img  class="icon-size" :src="require(`@/assets/icons/${imgStatus}`)">  
          <span>Entregue</span>
        </span>
        <br>
        <span style="font-weigth:bold;">
          R$50,00
        </span>
        <div v-show="moreDetails">
          <p> 1x Pizza de mussarela</p>
          <p>1x Pizza de brigadeiro</p>
          <p>1x Coca-cola zero</p>
            <br>
            <br>
        <h3>Forma de pagamento</h3>
        <p>Cartão de crédito</p>
        <br>
        <h3>Endereço entrega</h3>
        <p>Avenida paulista </p>
        
        </div>
        

    
    </div>
 
</template>

<script>
export default {
props:{
    status:'E'

    },
data(){
return{

moreDetails:false,

}


},

methods:{

    toggleMoreDetails(){
        this.moreDetails = !this.moreDetails;
        return this.moreDetails;

    }
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