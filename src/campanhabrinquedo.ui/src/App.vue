<template>
  <div id="app">
   <toolbar-menu :rotas="routes" />
   <div class="container">
    <transition name="pagina">
      <router-view></router-view>
    </transition>
   </div>
  </div>
</template>

<script>
import { routes } from "./routes";
import Menu from "./components/Shared/Menu/Menu.vue";
export default {
  components: {
    "toolbar-menu": Menu
  },
  name: "app",
  created() {
    var token = localStorage.getItem("token");
    if (!token) {
      this.$router.push({ name: "login" });
    }
  },
  data() {
    return {
      routes: routes.filter(route => route.menu)
    };
  }
};
</script>

<style lang="scss">
h2 {
  margin: 0;
}

.pagina-enter-active,
.pagina-leave-active {
  transition: opacity 0.3s;
}
.pagina-enter,
.pagina-leave-active {
  opacity: 0;
}

html,
body,
nav {
  margin: 0;
  padding: 0;
  border: 0;
  vertical-align: baseline;
}
</style>
