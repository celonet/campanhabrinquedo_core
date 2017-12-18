<template>
    <div>
        <img v-if="src !== undefined" :src="src" :alt="alt">
        <img v-else src="../../../assets/logo.png" alt="Default">
    </div>
</template>
<script>
export default {
  props: ["src","alt"]
}
</script>
<style scoped>
img {
  width: 100%;
}
</style>



