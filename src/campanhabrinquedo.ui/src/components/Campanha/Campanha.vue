<script>
export default {
  template: require("./Campanha.html"),
  data() {
    return {
      campanhas: []
    };
  },
  created() {
    this.$http
      .get("http://localhost:5000/api/campanha")
      .then(res => res.json(), err => console.log)
      .then(test => {
        this.campanhas = test;
      });
  }
};
</script>
<style lang="scss" scoped>
@import "./Campanha.scss";
</style>

