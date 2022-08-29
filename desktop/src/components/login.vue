<template>

    <div id="loginform" action="/home" method="post">
   

      <div class="container">
      <div >
        <label for="uname"><b>Login</b></label>
        <input type="text" placeholder="Insira o usuário" name="uname" required />

        <label for="psw"><b>Senha</b></label>
        <input
          type="password"
          placeholder="Insira senha"
          name="psw"
          required
        />

        <button @click="buttonClickLogin"  >Login</button>
        <label>
          <input type="checkbox" checked="checked" name="remember" /> Lembre-me        </label>
     </div>
      </div>

      <div class="container" style="background-color: #f1f1f1">
        <!-- <button   type="button" class="cancelbtn">Cancel</button> -->
        <span class="psw">Esqueci a <a href="#">senha?</a></span>
      </div>
    </div>
 </template>

<script>
import { mapGetters, mapActions } from "vuex";
export default {
  computed: {
    ...mapGetters("login", ["getIsLogado"]),
  },
  methods: {
    ...mapActions("login", ["setLogin"]),
    buttonClickLogin() {
      this.$router.push("/home");
      this.setLogin();
    },
  },
};
</script>

<style>

</style>