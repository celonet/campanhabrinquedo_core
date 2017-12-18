<script>
export default {
  template: require("./Comunidade.html"),
  data() {
    return {
      comunidades: []
    };
  },
  created() {
       this.$http
      .get("http://localhost:5000/api/comunidade")
      .then(res => res.json(), err => console.log)
      .then(test => {
        this.comunidades = test;
      });
  }
};
</script>
<style lang="scss" scoped>
@import url("./Comunidade.scss");
</style>
