<template>
<div class="container-fluid  ">
  <div class="row">
    <div class="col-md-12 text-center mt-2">
      Admin
    </div>
    <div class="col-md-12 d-flex align-items-center">
      <i class="mdi mdi-table"></i> <button class="btn border-0 text-light">Tables</button>
    </div>
  </div>
</div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";
import { logger } from "../utils/Logger.js"
import Pop from "../utils/Pop.js";

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
      }
    }
  }
</script>

<style lang="scss" scoped>
</style>
