<template>
  <b-card
    title="Team Name"
    img-src="https://picsum.photos/300/100/"
    img-alt="Image"
    img-top
    tag="article"
    style="max-width: 240px;max-height: 100px;margin:25px;display: inline-block;"
    class="mb-2"
  >
    <!-- <b-card-text style="text-align:center;">
         Player Description
      </b-card-text> -->
    <!-- <b-button href="#" variant="primary">+</b-button> -->
    <ul>
      <li>{{ teamName }}</li>
      <li>{{ teamOwner }}</li>
    </ul>
  </b-card>
</template>

<script>
export default {
  props: {
    teamName: String,
    teamOwner: String
  }
};
</script>
