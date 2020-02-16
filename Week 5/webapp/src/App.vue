<template>
  <div id="app">
    <img alt="The Simpsons" src="./assets/simpsons.jpg">
   <NavBar/>
   <router-view/>
  </div>
</template>

<script>
import NavBar from './components/NavBar.vue'

export default {
  name: 'App',
  components: {
    NavBar
  }
}
</script>

<style>

  body {
    background-color: lightblue;
  }
  
  #myHeading { 
          background-color: black; 
          font-family: 'Times New Roman', Times, serif;
          color: white; 
          padding: 8px; 
      } 
  
  p {
    font-family:'Courier New', Courier, monospace;
    color: white;
    font-size: 20px;
  }

  .tables { 
    background-color: black; 
    color: red; 
    padding: 8px; 
} 

</style>
