<template>
    <div class="menu-cliente">
        <img class="img-logo" src="../../assets/logo.png">
        <div class="menu-container">

            <ul class="menu-list">
                <li>FAZER UM PEDIDO</li>
                <li>CARDAPIO</li>
                <li>PROMOCÕES</li>
                <li>ACOMPANHAR MEU PEDIDO</li>
            </ul>
        </div>
        <div class="auth-options">
            <p>FAZER LOGIN <br>OU CADASTRAR-SE</p>
        </div>

        <div class="cart">
            <img src="../../assets/Cliente/carrinho-de-compras.png">
            <p>CARRINHO</p>

        </div>
    </div>
</template>

<style>
.img-logo {

    float: left;
    height: 100 px;
    width: 100px;
    position: relative;
    bottom: 10px;

}

ul {

    white-space: nowrap;
}

.menu-container {
    max-width: 50%;
    margin-left: 10%;
}


li {
    float: left;
    display: inline;
    color: white;
    list-style-type: none;
    padding-left: 2%;
    font-size: 1.2vw;
    font-weight: bold;
    font-family: "Raleway", sans-serif;
    cursor: pointer;


}

.cart {
    cursor: pointer;
    padding-right: 5vw;
    display: inline;
    float: right;
    position: relative;
    bottom: 10px;
}

.cart img {

    width: 35px;
    height: 35px;
}

.cart p {
    position: relative;
    bottom: 1vw;
    right: 0.8vw;
    color: white;
    font-weight: bold;
}

.auth-options {
    color: white;
    margin-left: 5%;
    display: inline-block;
    position: relative;
    bottom: 1vw;

}

.menu-cliente {
    left: 0;
    background-color: #C70404;
    height: 3.5vw;
    width: 100vw;
    position: absolute;
    top: 0;
    box-shadow: 0 10px 8px 0 rgba(0, 0, 0, 0.2);

}
</style>