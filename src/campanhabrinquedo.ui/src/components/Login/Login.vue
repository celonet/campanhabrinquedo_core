<script>
export default {
  template: require("./Login.html"),
  name: "login",
  data() {
    return {
      loader: false,
      infoError: false,
      email: "",
      password: ""
    };
  },
  beforeCreate() {
    if (store.state.isLogged) {
      router.push("/");
    }
  },
  methods: {
    //     login() {
    //       this.loader = true;
    //       this.infoError = false;
    //       this.$http
    //         .post("https://your-api-url.com/login", {
    //           email: this.email,
    //           password: this.password
    //         })
    //         .then(
    //           response => {
    //             localStorage.setItem("token", response.body.token);
    //             // store.commit("LOGIN_USER");
    //             router.push("/");
    //           },
    //           () => {
    //             this.infoError = true;
    //             this.loader = false;
    //             this.password = "";
    //           }
    //         );
    //     }
  }
};
</script>
<style lang="scss" scoped>
@import "./login.scss";
</style>
