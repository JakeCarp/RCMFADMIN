<template>
<div class="container-fluid  ">
  <div class="row">
    <div class="col-md-12 text-center mt-4 bg-primary lighten-10 rounded-1 elevation-5">
     <h3> Admin</h3>
    </div>
    <div class="col-md-12  mt-2">
     <!-- <button class="btn border-0 text-light p-2 fs-4 selectable w-100">  <i class="mdi mdi-table"></i>   Tables</button> -->

         <nav class="border-0">
          <div
            class="nav nav-tabs rounded flex-column border-0 "
            id="nav-tab"
            role="tablist"
          >
            <button
          
              class="nav-link active mt-4"
              id="nav-home-tab"
              data-bs-toggle="tab"
              data-bs-target="#nav-home"
              type="button"
              role="tab"
              aria-controls="nav-home"
              aria-selected="true"
            >
              <i class="mdi mdi-view-dashboard  me-1"></i> DashBoard
            </button>
            <button
          
              class="nav-link mt-4"
              id="nav-profile-tab"
              data-bs-toggle="tab"
              data-bs-target="#nav-profile"
              type="button"
              role="tab"
              aria-controls="nav-profile"
              aria-selected="false"
            >
              <i class="mdi mdi-account fs-2 me-1"></i> Members
            </button>
            <button
          
              class="nav-link mt-4"
              id="nav-contact-tab"
              data-bs-toggle="tab"
              data-bs-target="#nav-contact"
              type="button"
              role="tab"
              aria-controls="nav-contact"
              aria-selected="false"
            >
              <i class="mdi mdi-phone me-1"></i> Contact
            </button>

            <button
               
              class="nav-link mt-4"
              id="nav-fourth-tab"
              data-bs-toggle="tab"
              data-bs-target="#nav-fourth"
              type="button"
              role="tab"
              aria-controls="nav-fourth"
              aria-selected="false"
            >
             <i class="mdi mdi-calendar me-1"></i>  Events
            </button>
          </div>
        </nav>
    </div>
  
  </div>
  <div class="row mt-4">
    <div class="col-12">
           <button
         
            class="elevation-2 btn btn-outline-danger rounded-1 p-2 px-5 fw-bold fs-3"
          >
            Logout
          </button>
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


.test {
  height: 80vh;
}
img {
  max-width: 100px;
}
nav .active {
  border: 0;
  border-bottom: 5px solid #f5a53c !important;
  background-color: transparent !important;
  font-weight: bold;
}
nav .nav-link {
  color: rgb(255, 255, 255) !important;
  margin: 0 20px;
  font-size: 1.5rem;
  align-items: center;
  display: flex;
  border: 0;
  justify-content: end;
}

nav .nav-link:hover {
  border: none;
  border-bottom: #f5a53c 5px solid !important;
}

</style>
