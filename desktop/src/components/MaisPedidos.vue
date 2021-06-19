<template>
  <div>
    <h1>Produtos populares</h1>
    <div>
     <div id="cardPopulares">
        <img
          align="left"
          id="fotoPopular"
          src="../assets/imgs/portuguesa.jpg"
        />
        <div>
          <h2>Produto 2</h2>
          <h3>Quantidade de vendas</h3>
          <strong>200</strong>
        </div>
      </div>
    </div>
   
      <div id="cardPopulares">
        <img
          align="left"
          id="fotoPopular"
          src="../assets/imgs/portuguesa.jpg"
        />
        <div>
          <h2>Produto 2</h2>
          <h3>Quantidade de vendas</h3>
          <strong>200</strong>
        </div>
      </div>
    </div>


</template>

<script>
export default {};
</script>

<style>
#cardPopulares {
  width: 50%;
  display: inline-flex;
  border:solid;
  border-color:black;
  border-width: 1px;

  margin-bottom: 5%;
box-shadow: black;
}

#fotoPopular {
  width: 10vw;
  height: 10vw;
}
</style>

