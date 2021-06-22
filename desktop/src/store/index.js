import modal from './modules/modal';

import Vue from 'vue';
import Vuex from 'vuex';

Vue.use(Vuex);

export default new Vuex.Store({
  modules: {
    modal: { namespaced: true, ...modal },
 
  }
});






