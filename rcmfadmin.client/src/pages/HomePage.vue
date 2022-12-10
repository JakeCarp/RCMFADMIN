<template>
  <div class="container-fluid mt-4">
    <div class="row">
      <!-- <div class="col-md-3 test d-flex flex-column  justify-content-between ">
     
      </div> -->
      <div class="col-md-12 d-flex justify-content-center">
        <div>
     
        </div>
        <h1 class="abril">Admin DashBoard </h1>
    
      </div>
      <div class="col-md-12">
        <!-- NavButtons -->
    
        <!-- !NavButtons -->
        <div class="tab-content" id="nav-tabContent">
          <div
            class="tab-pane fade show active"
            id="nav-home"
            role="tabpanel"
            aria-labelledby="nav-home-tab"
            tabindex="0"
          >
            <!-- Tab1 -->
            <Tab1 />
            <!-- !Tab1 -->
          </div>
          <div
            class="tab-pane fade"
            id="nav-profile"
            role="tabpanel"
            aria-labelledby="nav-profile-tab"
            tabindex="0"
          >
            <!-- Tab2 -->
            <MembersTab/>
            <!-- !Tab2 -->
          </div>
          <div
            class="tab-pane fade"
            id="nav-contact"
            role="tabpanel"
            aria-labelledby="nav-contact-tab"
            tabindex="0"
          >
            <!-- Tab3 -->
            <!-- !Tab3 -->
          </div>
          <div
            class="tab-pane fade"
            id="nav-fourth"
            role="tabpanel"
            aria-labelledby="nav-fourth-tab"
            tabindex="0"
          >
            <!-- Tab4 -->
            <EventsTab/>
            <!-- !Tab4 -->
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { computed } from "vue";
import { AppState } from "../AppState";
import EventsTab from "../components/EventsTab.vue";
import MembersTab from "../components/MembersTab.vue";
import Tab1 from "../components/Tab1.vue";

export default {
  setup() {

    return {
      account: computed(() => AppState.account),
    };
  },
  components: { Tab1, MembersTab, EventsTab },
};
</script>

<style scoped>
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
  color: black !important;
  margin: 0 20px;
  font-size: 1.5rem;
  align-items: center;
  display: flex;
}

nav .nav-link:hover {
  border: none;
  border-bottom: #f5a53c 5px solid !important;
}
</style>
