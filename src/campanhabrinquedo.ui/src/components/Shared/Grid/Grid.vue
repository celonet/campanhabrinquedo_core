<template>
<table>
    <thead>
      <tr v-for="column in columns" :key="column">
        <th>{{column}}</th>
      </tr>
    </thead>
    <tbody>
      <tr v-for="d in data" :key="d.id">
        <td> {{ crianca.nome }} </td>
        <td> {{ crianca.idade }} </td>
        <td> {{ crianca.comunidade.nome }} </td>
        <td> {{ crianca.responsavel.nome }} </td>
      </tr>
    </tbody>
  </table>  
</template>
<script>
export default {
  props: ["data"],
  data() {
    return {
      columns: []
    };
  }
};
</script>

