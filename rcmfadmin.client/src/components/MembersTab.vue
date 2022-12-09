<template>
<div class="container">
  <div class="row my-2 g-2">
    <div class="table-responsive">
  <table class="table 
  table-hover	
  table-borderless
  
  align-middle">
    <thead class="table-light">
      <caption>Donations</caption>
      <tr>
        <th>Name</th>
        <th>Email</th>
        <th>Amount</th>
        <th>Donation Date</th>
      </tr>
      </thead>
      <tbody class="table-group-divider ">
        <tr class="table"  v-for="d in donors" >
        
          <td>{{d.name}}</td>
          <td>{{d.email}}</td>
          <td>{{d.amount}}</td>
          <td>{{new Date(d.createdAt).toDateString()}}</td>

        </tr>
    
      </tbody>
      <tfoot>
        
      </tfoot>
  </table>
</div>




  </div>

  <div class="row my-2 g-2">
        <div class="table-responsive">
  <table class="table 
  table-hover	
  table-borderless
  
  align-middle">
    <thead class="table-light">
      <caption>Sponsors</caption>
      <tr>
        <th>Name</th>
        <th>Email</th>
        <th>Tier</th>
        <th>Sponsorship Date</th>
      </tr>
      </thead>
      <tbody class="table-group-divider ">
        <tr class="table"  v-for="s in sponsors" >
        
          <td>{{s.name}}</td>
          <td>{{s.email}}</td>
          <td>{{s.tier}}</td>
          <td>{{new Date(s.createdAt).toDateString()}}</td>

        </tr>
    
      </tbody>
      <tfoot>
        
      </tfoot>
  </table>
</div>


  </div>
</div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";


export default {
props:{

       },
  setup(props) {
    const editable = ref({});
    
    onMounted(() => {

    });
    watchEffect(() => {});

    return {
      editable,
        donors: computed(() => AppState.donors),
        sponsors:computed(() => AppState.sponsors),

      }
    }
  }
</script>

<style lang="scss" scoped>
</style>
