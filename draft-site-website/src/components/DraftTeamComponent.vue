<template>
  <div style="margin:25px;display: inline-block;">
    <b-card
      img-src="https://picsum.photos/300/100/"
      img-alt="Image"
      img-top
      tag="article"
      style="max-width: 240px;max-height: 200px;"
      class="mb-2"
    >
      <b-card-text>
        <p>
          <span style="text-align:center;font-size:20px;"
            ><strong>{{ teamName }}</strong></span
          ><br />
          <span style="text-align:center;font-size:16px;">{{ teamOwner }}</span>
        </p>
      </b-card-text>
    </b-card>
  </div>
</template>

<script>
export default {
  props: {
    teamName: String,
    teamOwner: String
  },
  computed: {
    isActive() {
      return this.teamOwner;
    }
  }
};
</script>
