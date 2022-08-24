<template>

    <div  class="card-pedidos" :class="{maisDetalhes:moreDetails}">
        <span style="">
        {{this.dataPedido}}

        </span>
        <span class="card-pedidos-type-text">
       {{this.tipoPedido}}
        <img class="icon-size detalhes-pedido" @click="toggleMoreDetails" src="../../assets/icons/setabaixo.png">
        </span>
        <br>
        <br>
        <span class="card-pedidos-status-text">
          <img  class="icon-size" :src="require(`@/assets/icons/${imgStatus}`)">  
          <span>{{this.status == 'E' ? 'ENTREGUE':'PREPARANDO'}}</span>
        </span>
        <br>
        <span style="font-weigth:bold;">
         R${{this.precoPedido}}
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
    status:'E',
    dataPedido:'',
    precoPedido:'',
    tipoPedido:'',



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
.maisDetalhes{
height: 25vw;

}
</style>