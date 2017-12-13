<script>
export default {
  template: require("./Menu.html"),
  props: {
    rotas: {
      type: Array,
      required: true
    }
  },
  created() {
    $(document).ready(function() {
      $(".button-collapse").sideNav({
        menuWidth: 300, // Default is 300
        edge: "left", // Choose the horizontal origin
        closeOnClick: false, // Closes side-nav on <a> clicks, useful for Angular/Meteor
        draggable: true // Choose whether you can drag to open on touch screens
      });
      // START OPEN
      $(".button-collapse").sideNav("show");
    });
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
