<template>
  <div class="login-bg">
    <div class="loginBox">
      <div class="fields">
        <div style="max-width: 70%">
          <input type="text" placeholder="Login" name="uname" required />
        </div>
        <div style="max-width: 70%">
          <input type="password" placeholder="Senha" name="psw" required />
        </div>
        <div style="max-width: 70%">
          <button @click="buttonClickLogin">Login</button>
          <label>
            <input type="checkbox" checked="checked" name="remember" />
            Lembre-me
          </label>
        </div>
      </div>
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
.loginBox {
  width: 20%;
  margin: auto;
  position: fixed;
  left: 40%;
  top: 25%;
  height: 50%;
  background-color: white;
  box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2);

}
.fields{
    margin: 2vw;
    position: relative;
    left: 2vw;
    top: 2vw;
}
</style>