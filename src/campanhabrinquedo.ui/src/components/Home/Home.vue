<script>
import HomeCard from "./HomeCard/HomeCard.vue";

export default {
  template: require("./Home.html"),
  components: {
    "home-card": HomeCard
  },
  created() {},
  data() {
    return {
      campanha: 2017,
      criancas: [],
      qtdeCriancas: 0,
      qtdePadrinhos: 0,
      qtdeResponsaveis: 0,
      qtdeComunidades: 0,
      filtro: ''
    };
  },
  computed: {
    filtraCrianca() {
      if (this.filtro) {
        let exp = new RegExp(this.filtro.trim(), "i");
        return this.criancas.filter(crianca => exp.test(crianca.nome));
      } else {
        return this.criancas;
      }
    }
  }
};
</script>

<style>
@import url("./Home.scss");
</style>

