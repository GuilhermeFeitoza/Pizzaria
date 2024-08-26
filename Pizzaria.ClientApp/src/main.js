import Vue from 'vue'
import App from './App.vue'
import '../src/style.css'
import VueRouter from "vue-router";
import  router from '../src/index.js'
import store from '../src/store/index.js'
import '@progress/kendo-ui' // This will import the entire Kendo UI library
// As an alternative, you could import only the scripts that are used by a specific widget:
// import '@progress/kendo-ui/js/kendo.grid' // Imports only the Grid script and its dependencies
import '@progress/kendo-theme-default/dist/all.css'

import ToastPlugin from 'vue-toast-notification';
// Import one of the available themes
//import 'vue-toast-notification/dist/theme-default.css';
import 'vue-toast-notification/dist/theme-default.css';


import { Grid } from '@progress/kendo-grid-vue-wrapper'
import { DatePicker } from '@progress/kendo-vue-dateinputs';
Vue.component('DatePicker',DatePicker)
Vue.component('Grid', Grid);
// const app = createApp({}).mount('#app')
// app.use(VueToast);

//App.use(VueToast);

Vue.config.productionTip = false

new Vue({
  render: h => h(App),
  router,
  store,
  components: {
   
}
}).$mount('#app')
