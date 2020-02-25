<template style="">
<a href=#>
   <b-card 
      
      img-src="https://picsum.photos/300/300/"
      img-alt="Image"
      img-top
      tag="article"
      style="max-width: 100px;max-height: 100px;margin:25px;display: inline-block;"
      class="mb-2"
      >
      <b-card-text style="text-align:center;font-size:14px;">
         Player Name
      </b-card-text>
      <!-- <b-button href="#" variant="primary">+</b-button> -->
   </b-card>
</a>
</template>

<script>
export default {
   props: {
      playerName: String,
      img: String
   }
}
</script>