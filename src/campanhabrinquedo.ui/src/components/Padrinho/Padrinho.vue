<script>
export default {
  template: require("./Padrinho.html"),
  data() {
    return {
      padrinhos: []
    };
  },
  created() {
    this.$http
      .get("http://localhost:5000/api/padrinho")
      .then(res => res.json(), err => console.log)
      .then(test => (this.padrinhos = test));
  }
};
</script>
<style lang="scss" scoped>
@import url("./Padrinho.scss");
</style>
