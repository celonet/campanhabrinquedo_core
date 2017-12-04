<script>
export default {
  template: require("./Crianca.html"),
  data() {
    return {
      criancas: []
    };
  },
  created() {
    this.$http
      .get("http://localhost:5000/api/crianca")
      .then(res => res.json(), err => console.log)
      .then(test => {
        this.criancas = test;
      });
  }
};
</script>
<style lang="scss" scoped>
@import url("./Crianca.scss");
</style>
