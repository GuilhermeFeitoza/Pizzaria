<template>
    <div class="card-avaliacao">
        <h1 class="review-title"> Titulo da avaliação</h1>
        <p>Nome do avaliador</p>
        <div class="center-stars">
            <span class="fa fa-star checked"></span>
            <span class="fa fa-star checked"></span>
            <span class="fa fa-star checked"></span>
            <span class="fa fa-star"></span>
            <span class="fa fa-star"></span>
        </div>
        <p class="review-text">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam dignissim magna lorem, non finibus velit
            aliquam nec.
        </p>

        <p>03/11/2024 14:49</p>
    </div>
</template>
<style>
.card-avaliacao {
    box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);
    border-radius: 0.5vw;
    margin-left: 2vw;
    min-width: 30vw;
    width: 20vw;
    height: 40vh;


}

.checked {
    color: orange;
}

.reviewText {
    font-size: 8px;
    color: gray;

}

.review-title {

    font-size: 14px;

}

.center-stars {
    margin: auto;
    width: 50%;
}
</style>