<template>
  <div style="margin:25px;display: inline-block;">
    <b-card
      img-src="https://picsum.photos/300/100/"
      img-alt="Image"
      img-top
      tag="article"
      style="max-width: 150px;max-height: 250px;"
      class="mb-2"
    >
      <b-card-text>
        <p>
          <span style="text-align:center;font-size:20px;"
            ><strong>{{ playerName }}</strong></span
          ><br />
          <span style="text-align:center;font-size:16px;">{{
            playerCollege
          }}</span>
        </p>
      </b-card-text>
      <!-- <b-button href="#" variant="primary">+</b-button> -->
    </b-card>
  </div>
</template>

<script>
export default {
  props: {
    playerName: String,
    playerCollege: String,
    isSelected: Boolean
  },
  computed: {
    isActive() {
      return this.isSelected;
    }
  }
};
</script>
