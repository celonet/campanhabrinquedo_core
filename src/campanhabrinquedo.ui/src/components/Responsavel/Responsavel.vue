<script>
export default {
  template: require("./Responsavel.html"),
  data() {
    return {
      responsaveis: []
    };
  },
  created() {
    this.$http
      .get("http://localhost:5000/api/responsavel")
      .then(res => res.json(), err => console.log)
      .then(test => (this.responsaveis = test));
  }
};
</script>
<style lang="scss" scoped>
@import url("./Responsavel.scss");
</style>
