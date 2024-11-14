<template>

    <div>
        <div class="content">
            <h1> EXPERIMENTE HOJE MESMO AS NOSSAS PIZZAS MAIS POPULARES</h1>

        </div>
        <div class="podium">
            <!-- Troféus acima das posições -->
            <!-- <div class="trophy-container">
                <img src="../../assets/Cliente/number1.png" alt="Troféu 1º Lugar" class="trophy" />
                <img src="../../assets/Cliente/number1.png" alt="Troféu 2º Lugar" class="trophy" />
                <img src="../../assets/Cliente/number1.png" alt="Troféu 3º Lugar" class="trophy" />
            </div> -->

            <!-- Posições no pódio -->
            <div class="podium-container">
                <img src="../../assets/Cliente/number2.png" alt="Troféu 2º Lugar" class="trophy-third" />
                <div class="podium-position-second ">
                    <img src="../../assets/imgs/brigadeiro.jpg" alt="2º Lugar" />
                </div>
                <img src="../../assets/Cliente/number1.png" alt="Troféu 1º Lugar" class="trophy-first" />
                <div class="podium-position-first ">
                   
                    <img class="pizza-image-first" src="../../assets/imgs/calabresa.jpg" alt="2º Lugar" />
                   
                </div>
               
                <img src="../../assets/Cliente/number3.png" alt="Troféu 3º Lugar" class="trophy-second" />
                <div class="podium-position-third">
                    <img src="../../assets/imgs/frangoc.jpg" alt="3 Lugar" />
                </div>

            </div>
        </div>
    </div>
</template>
<style>
.content {

    margin-top: 5%;
    width: 60%;
    margin-left: auto;
    margin-right: auto;
    text-align: center;

}

.podium {
    display: flex;
    flex-direction: column;
    align-items: center;
}



.trophy-first {
    width: 70px;
    height: 70px;
    position: relative;
    bottom:  21vw;
    left: 20vw;
}
.trophy-second {
    width: 70px;
    height: 70px;
    position: relative;
    bottom:  16vw;
    left: 16vw;
}
.trophy-third {
    width: 70px;
    height: 70px;
    position: relative;
    bottom:  15vw;
    left: 15vw;
}


.podium-container {
    display: flex;
    align-items: flex-end;
    gap: 10px;
    margin-top: 4vw;
    /* Para sobrepor as imagens com o troféu */
}

.podium-position-first {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 20vw;
    width: 35vw;
    border-radius: 10px;
}

.podium-position-second {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 15vw;
    width: 25vw;
    border-radius: 10px;
}

.podium-position-third {
    display: flex;
    justify-content: center;
    align-items: center;
    height: 15vw;
    width: 25vw;
    border-radius: 10px;
}


.podium-position-first img,
.podium-position-second img,
.podium-position-third img {
    width: 80%;
    height: auto;
    border-radius: 20px;

}

.pizza-image-first {

    height: 20vw;
    width: 30vw;

}
</style>