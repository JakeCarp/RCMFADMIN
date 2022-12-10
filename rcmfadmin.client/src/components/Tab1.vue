<template>
  <div class="container p-4">
    <div class="row">
      <div class="col-md-4 my-2">
        <div class="card p-2  border-0 bg-white">
          <div class="d-flex justify-content-between p-2">
            <div class="">
              <p class="fw-bold mb-0">Donations</p>
              <p class="roboto text-grey">
                Total Count since {{ new Date().toLocaleDateString() }}
              </p>
            </div>
            <img
              src="https://cdn-icons-png.flaticon.com/512/639/639365.png"
              alt=""
              width="75"
              height="75"
            />
          </div>
          <div class="text-center">
            <p class="roboto display-2 text-shadow2">${{ total }}</p>
            <p class="roboto fs-5 text-shadow2">
              More Information on MemberTab
            </p>
          </div>
        </div>
      </div>
      <div class="col-md-4 my-2">
        <div class="card p-2 border-0 bg-white lighten-0">
          <div class="d-flex justify-content-between p-2">
            <div class="">
              <p class="fw-bold mb-0">NewsLetter Subscriptions</p>
              <p class="roboto">
                Total Count since {{ new Date().toLocaleDateString() }}
              </p>
            </div>
            <img
              src="https://cdn-icons-png.flaticon.com/512/3187/3187067.png"
              alt=""
              width="75"
              height="75"
            />
          </div>
          <div class="text-center">
            <p class="roboto display-2 text-shadow2">
              {{ subScribers.length }}
            </p>
            <p class="roboto fs-5 text-shadow2">
              More Information on MemberTab
            </p>
          </div>
        </div>
      </div>
      <div class="col-md-4 my-2">
        <div class="card p-2  border-0 bg-white lighten-0">
          <div class="d-flex justify-content-between p-2">
            <div class="">
              <p class="fw-bold mb-0">Grant Applications</p>
              <p class="roboto">
                Total Count since {{ new Date().toLocaleDateString() }}
              </p>
            </div>
            <img
              src="https://cdn-icons-png.flaticon.com/512/8632/8632992.png"
              alt=""
              width="75"
              height="75"
            />
          </div>
          <div class="text-center">
            <p class="roboto display-2 text-shadow2">
              {{ grants.length }}
            </p>
            <p class="roboto fs-5 text-shadow2">
              More Information on MemberTab
            </p>
          </div>
        </div>
      </div>

      <div class="col-md-6 my-3">
        <div class="card p-2 elevation-6 border-0">
          <div class="d-flex justify-cont   ent-between p-2">
            <p class="fw-bold">Upcoming Event</p>
            <img
              src="https://cdn-icons-png.flaticon.com/512/3277/3277487.png"
              alt=""
              width="75"
              height="75"
            />
          </div>

        <div class="">
 <p> Details: Lorem ipsum dolor sit amet consectetur adipisicing elit. Sapiente molestias perspiciatis esse sed odio ducimus deleniti itaque assumenda dolor. Quidem, autem corrupti sapiente distinctio quibusdam aliquid ipsam quam unde modi magnam exercitationem possimus voluptates?</p>

 <p> Location :    </p>
        </div>
        </div>
      </div>






      <div class="col-md-6 my-3">
        <div class="card p-2 elevation-6 border-0">
          <div class="d-flex justify-content-between p-2">
            <p class="fw-bold">Sponsors</p>
            <img
              src="https://cdn-icons-png.flaticon.com/512/1672/1672241.png"
              alt=""
              width="75"
              height="75"
            />
          </div>

          <div
            class="card p-1 elevation-2 border d-flex justify-content-evenly scrollY"
          >
            <div
              class="d-flex justify-content-around p-2 rounded selectable"
              v-for="s in sponsors"
            >
              <p>{{}}</p>
              <p>{{ s.name }}</p>
              <p>{{ s.email }}</p>
              <p>{{ s.tier }}</p>
              <p>{{ s.createdAt }}</p>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { computed } from "@vue/reactivity";
import { onMounted, ref, watchEffect } from "vue";
import { AppState } from "../AppState.js";
import Pop from "../utils/Pop.js";

export default {
  props: {},
  setup(props) {
    const editable = ref({});
    onMounted(() => {});
    watchEffect(() => {});

    return {
      editable,
      sponsors: computed(() => AppState.sponsors),
      donors: computed(() => AppState.donors),
      total: computed(() => AppState.donationTotal),
      grants: computed(() => AppState.grants),
      subScribers: computed(() => AppState.newsletterSubscribers),
      // monthTotal: computed(() =>
      //   AppState.donors.forEach((d) => {
      //     let current = new Date(Date.now());
      //     let donorDate = new Date(d.createdAt);

      //     if (donorDate == current) {
      //       AppState.monthTotal += d.amount;
      //     }
      //     return AppState.monthTotal;
      //   })
      // ),
    };
  },
  components: {},
};
</script>

<style lang="scss" scoped>
.gradient1 {
  background: rgb(2, 0, 36);
  background: linear-gradient(
    90deg,
    rgba(2, 0, 36, 0.8590029761904762) 0%,
    rgba(68, 207, 108, 1) 100%
  );
}
.gradient2 {
  background: rgb(2, 0, 36);
  background: linear-gradient(
    90deg,
    rgba(2, 0, 36, 0.8590029761904762) 0%,
    rgba(214, 64, 69, 1) 100%
  );
}
.scrollY {
  height: 30vh;
  width: auto;
  overflow-y: auto;
  overflow-x: hidden;
}
</style>
