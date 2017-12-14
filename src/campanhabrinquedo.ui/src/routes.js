import Home from './components/Home/Home.vue';
import Login from './components/Login/Login.vue';
import Campanha from './components/Campanha/Campanha.vue';
import Comunidade from './components/Comunidade/Comunidade.vue';
import Padrinho from './components/Padrinho/Padrinho.vue';
import Responsavel from './components/Responsavel/Responsavel.vue';
import Crianca from './components/Crianca/Crianca.vue';

export const routes = [
    { path: '/login', name: 'login', component: Login, title: 'Login', menu: true },
    { path: '', name: 'home', component: Home, title: 'Home', menu: true },
    { path: '/campanha', name: 'campanha', component: Campanha, title: 'Campanha', menu: true },
    { path: '/comunidade', name: "comunidade", component: Comunidade, title: 'Comunidade', menu: true },
    { path: '/padrinho', name: "padrinho", component: Padrinho, title: 'Padrinho', menu: true },
    { path: '/responsavel', name: "responsavel", component: Responsavel, title: 'Responsavel', menu: true },
    { path: '/Crianca', name: "crianca", component: Crianca, title: 'Criança', menu: true }
];