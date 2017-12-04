<template>
  <div id="app">
   <toolbar-menu :rotas="routes" />
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
  data() {
    return {
       routes: routes.filter(route => route.menu)
    };
  }
};
</script>

<style lang="scss">
body {
  background-color: #f6f6f6;
}

.pagina-enter-active,
.pagina-leave-active {
  transition: opacity 0.3s;
}
.pagina-enter,
.pagina-leave-active {
  opacity: 0;
}
</style>
