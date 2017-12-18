<template>
    <div class="card horizontal">
        <div class="card-stacked">
          <div class="card-content">
            <div class="card-title">{{qtde}}</div>
            <div class="card-subhead">{{titulo}}</div>
          </div>
          <div class="card-action">
            <a href="#">Ver mais...</a>
          </div>
        </div>
        <div class="card-image">
            <my-image></my-image>
        </div>
    </div>
</template>

<script>
import Image from "./../../Shared/Image/Image.vue";

export default {
  components: {
    "my-image": Image
  },
  props: ["qtde", "titulo"]
};
</script>

