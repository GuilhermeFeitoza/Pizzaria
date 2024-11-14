<template>

    <div>
        <nav-bar-cliente></nav-bar-cliente>
        <div class="content">
            <try-our-most-popular></try-our-most-popular>
            <div class="reserve-create-pizza">
                <div style="float: left; font-weight: bold;">
                    <p>AFIM DE NOS VISITAR E TER UMA <br>
                        EXPERIÊNCIA TOTALMENTE DELICIOSA?</p>
                    <img src="../../assets/Cliente/table.png">
                    <p>Disponibilizamos reserva de mesas para <br>que sua experiência seja a melhor possivel</p>
                    <a href="">Faça uma reserva hoje mesmo aqui</a>
                </div>
                <div style="float: right; position: relative; bottom: 10px;">
                    <h1 style=""> AQUI VOCÊ PODE SER O <br> CHEF!!!</h1>
                    <img style="height: 10vw;width: 10vw;" src="../../assets/Cliente/chef.png"></img>
                    <p>Isso mesmo, aqui você pode criar sua própria pizza</p>
                    <a href="">Monte sua pizza aqui!!</a>


                </div>


            </div>
        </div>
    </div>
</template>
<script>
import navBarCliente from './nav-bar-cliente.vue';
import TryOurMostPopular from './try-our-most-popular.vue';
export default {

    components: {
        navBarCliente,
        TryOurMostPopular
    }
}
</script>
<style>
@import url('https://fonts.googleapis.com/css2?family=Raleway:wght@100;400&display=swap');

a {
    font-weight: normal;
    font-family: 'Raleway', sans-serif;
    color: #DE1313;
    text-decoration: underline;

}


.reserve-create-pizza {
    margin-top: 10%;
   height:30vw;

}
</style>