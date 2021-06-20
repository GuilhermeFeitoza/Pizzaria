import Vue from 'vue'
import App from './App.vue'
import '../src/style.css'
import VueRouter from "vue-router";
import  router from '../src/index.js'
import '@progress/kendo-ui' // This will import the entire Kendo UI library
// As an alternative, you could import only the scripts that are used by a specific widget:
// import '@progress/kendo-ui/js/kendo.grid' // Imports only the Grid script and its dependencies
import '@progress/kendo-theme-default/dist/all.css'

import { Grid } from '@progress/kendo-grid-vue-wrapper'

Vue.component('Grid', Grid);


Vue.config.productionTip = false

new Vue({
  render: h => h(App),
  router,
  components: {
   
}
}).$mount('#app')
