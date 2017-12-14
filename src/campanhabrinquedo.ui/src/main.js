import Vue from 'vue';
import VueResource from 'vue-resource';
import App from './App.vue';
import Vuex from 'vuex';
import VueRouter from 'vue-router';

import { routes } from './routes';

import 'materialize-css/dist/css/materialize.min.css';
import 'materialize-css/dist/js/materialize.min.js';

Vue.use(VueResource);
Vue.http.options.root = 'http://localhost:5000/';
Vue.use(VueRouter);

const router = new VueRouter({
  routes,
  mode: 'history'
});

Vue.http.interceptors.push((req, next) => {
  if (localStorage.length == 0) {
    next(function (response) {
      if (response.status == 401) {
        router.push({ name: 'login' });
      }
    });
  } else {
    var token = localStorage.getItem('token');
    req.headers.set('Authorization', `bearer ${token}`);
    next();
  }
});

new Vue({
  el: '#app',
  router,
  render: h => h(App)
})
