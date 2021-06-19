import VueRouter from "vue-router";
import Vue from "vue/types/umd";

import Home from "./components/Home.vue"
import Clientes from "./components/Clientes.vue"

const routes = [
    {path:'/home',component:Home},
    {path:'/clientes',component:Clientes}



]