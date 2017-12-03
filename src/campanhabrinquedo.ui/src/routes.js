import Home from './components/Home/Home.vue';
import Login from './components/Login/Login.vue';

export const routes = [
    { path: '*', component: Login },
    { path: '', component: Home }
];