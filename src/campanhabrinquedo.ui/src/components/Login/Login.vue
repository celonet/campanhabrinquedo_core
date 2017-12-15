<script>
import UsuarioService from "./../../domain/usuarioService";

export default {
  template: require("./Login.html"),
  data() {
    return {
      loader: false,
      infoError: false,
      messageError: "",
      email: "",
      password: ""
    };
  },
  created() {
    this.usuarioService = new UsuarioService(this.$resource);
  },
  methods: {
    login() {
      this.loader = true;
      this.infoError = false;
      this.usuarioService
        .login({
          usuario: this.email,
          senha: this.password
        })
        .then(
          response => {
            console.log(response);
            localStorage.setItem("token", response.body.access_token);
            this.$router.push({ name: "home" });
          },
          err => {
            this.infoError = true;
            this.loader = false;
            this.password = "";
            this.messageError = err.message;
          }
        );
    }
  }
};
</script>
<style lang="scss" scoped>
@import "./login.scss";
</style>
