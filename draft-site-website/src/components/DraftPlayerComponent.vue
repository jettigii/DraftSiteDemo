<template>
  <div>
    <b-card
      title="Player Name"
      img-src="https://picsum.photos/300/300/"
      img-alt="Image"
      img-top
      tag="article"
      style="max-width: 240px;max-height: 240px;margin:25px;display: inline-block;"
      class="mb-2"
    >
      <ul>
        <li>{{ playerName }}</li>
        <li>{{ playerCollege }}</li>
      </ul>
    </b-card>
  </div>
</template>

<script>
export default {
  props: {
    playerName: String,
    playerCollege: String
  }
};
</script>
