<script>
export default {
  template: require("./Login.html"),
  data() {
    return {
      loader: false,
      infoError: false,
      email: "",
      password: ""
    };
  },
  beforeCreate() {},
  methods: {
    login() {
      this.loader = true;
      this.infoError = false;
      this.$http
        .post("http://localhost:5000/api/usuario/token", {
          usuario: this.email,
          senha: this.password
        })
        .then(
          response => {
            localStorage.setItem("token", response.body.access_token);
            this.$router.push({ name: "home" });
          },
          err => {
            this.infoError = true;
            this.loader = false;
            this.password = "";
            console.log(err);
          }
        );
    }
  }
};
</script>
<style lang="scss" scoped>
@import "./login.scss";
</style>
