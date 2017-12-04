import Vue from 'vue';
import VueResource from 'vue-resource';
import App from './App.vue';
import Vuex from 'vuex';
import VueMaterial from 'vue-material';
import VueRouter from 'vue-router';

import { routes } from './routes';

import 'vue-material/dist/vue-material.css';

Vue.use(VueResource);
Vue.http.options.root = 'http://localhost:5000/';
Vue.use(VueMaterial);
Vue.use(VueRouter);

Vue.material.registerTheme('default', {
  primary: 'indigo',
  accent: 'pink',
  warn: 'deep-orange',
  background: 'white'
});

Vue.http.interceptors.push((req, next) => {
  if (localStorage.length == 0) {
    next();
  } else {
    var token = localStorage.getItem('token');
    req.headers.set('Authorization', `bearer ${token}`);
    next();
  }
});

const router = new VueRouter({
  routes,
  mode: 'history'
});

new Vue({
  el: '#app',
  router,
  render: h => h(App)
})
