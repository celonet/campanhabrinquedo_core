import Vue from 'vue';
import VueResource from 'vue-resource';
import App from './App.vue';
import Vuex from 'vuex';
import VueRouter from 'vue-router';
import { routes } from './routes';

import 'materialize-css/dist/css/materialize.min.css';
import 'materialize-css/dist/js/materialize.min.js';

const router = new VueRouter({
  routes,
  mode: 'history'
});

Vue.use(VueRouter);
Vue.use(VueResource);
Vue.http.options.root = 'http://localhost:5000/api/';
Vue.http.interceptors.push((req, next) => {
  var token = localStorage.getItem('token');
  if (token) {
    req.headers.set('Authorization', `bearer ${token}`);
    next();
  } else {
    next();
    // if (req.status == 401) {
    //   router.push({
    //     name: 'login'
    //   });
    // }
  }
});

new Vue({
  el: '#app',
  router,
  render: h => h(App)
})
