<template>
  <nav>
    <div class="nav-wrapper  indigo accent-2">
      <a href="#" data-activates="mobile-demo" class="button-collapse show-on-large">
        <i class="material-icons">menu</i>
      </a>
      <h2 class="md-title">Campanha do Brinquedo</h2>

      <ul class="side-nav grey darken-2" id="mobile-demo">
        <li class="blue" v-for="rota in rotas" :key="rota.name">
          <router-link :to="rota.path || '/'">{{rota.title}}</router-link>
        </li>
      </ul>
    </div>
  </nav>  
</template>

<script>
export default {
  props: {
    rotas: {
      type: Array,
      required: true
    }
  },
  created() {
    $(document).ready(function() {
      $(".button-collapse").sideNav({
        menuWidth: 300,
        edge: "left",
        closeOnClick: true,
        draggable: true
      });
    });
  }
};
</script>
<style scoped lang="scss">
nav {
  margin-bottom: 40px;
}
.side-nav li > a {
  padding: 0 16px;
}

.side-nav .divider {
  margin: 0;
  height: 8px;
  border-bottom: 1px solid #e0e0e0;
  background-color: transparent;
}

/* SIDENAV HEADER */
.sidenav-header {
  background-size: cover;
  margin-bottom: 0px;
  padding: 15px 0 0 15px;
  .row {
    margin-bottom: 0;
  }
}

.sidenav-footer {
  margin-bottom: 0px;
  padding: 0;
  .row {
    margin-bottom: 0;
    .social-icons {
      a {
        opacity: 0.5;
        padding: 0;
        text-align: center;
        &:hover {
          background-color: inherit;
          opacity: 1;
        }
      }
    }
  }
}
</style>
