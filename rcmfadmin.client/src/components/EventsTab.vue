<template>
  <div class="container">
    <div class="row">
      <div class="col-md-12">
        <button
          type="button"
          class="btn btn-outline-success elevation-2 mt-2 fs-4"
          data-bs-toggle="modal"
          data-bs-target="#createTournament"
        >
          Create Tournament Event
        </button>
      </div>
      <div class="col-md-12 text-center">
        <div>
          <p class="display-3 roboto">Upcoming Events</p>
        </div>
      </div>
      <div class="col-md-12 my-2">
        <div class="card border-0 elevation-6 p-3">
          <div class="row">
            <div class="col-md-6 d-flex justify-content-center">
              <img
                src="https://scottspinofoundation.org/wp-content/uploads/2016/06/golf-09.jpg"
                alt=""
                class="event-image img-fluid rounded elevation-1"
              />
            </div>
            <div class="col-md-6">
              <div class="text-center">
                <p class="roboto display-5">Golf Tournament</p>
              </div>

              <p>Location: 117something street, ID, 83642</p>
              <div class="">
                <p class="">Teams:</p>
              </div>
              <div class="">
                <p>Players:</p>
              </div>
              <div class="">
                <p>Other Details:</p>
              </div>
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

export default {
  props: {},
  setup(props) {
    const editable = ref({});

    onMounted(() => {});
    watchEffect(() => {});

    return {
      editable,
    };
  },
};
</script>

<style lang="scss" scoped></style>
