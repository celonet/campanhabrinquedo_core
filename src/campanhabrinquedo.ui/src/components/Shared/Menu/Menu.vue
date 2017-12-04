<script>
export default {
  template: require("./Menu.html"),
  props: {
    rotas: {
      type: Array,
      required: true
    }
  },
  methods: {
    toggleLeftSidenav() {
      this.$refs.leftSidenav.toggle();
    },
    close() {
      this.$refs.leftSidenav.close();
    }
  }
};
</script>
