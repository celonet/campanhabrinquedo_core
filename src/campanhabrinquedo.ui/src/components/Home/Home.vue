<script>
import Image from './../Shared/Image/Image.vue';
import HomeCard from './HomeCard/HomeCard.vue';

export default {

  template: require("./Home.html"),
  components: {
    "my-image": Image,
    "home-card": HomeCard
  },
  data() {
    return {
      campanha: 2017,
      qtdeCriancas: 0,
      qtdePadrinhos: 0,
      qtdeResponsaveis: 0,
      qtdeComunidades: 0,
    };
  }
};
</script>

<style>
@import url("./Home.scss");
</style>

