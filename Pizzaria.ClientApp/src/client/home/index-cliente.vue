<template>

    <div>
        <nav-bar-cliente></nav-bar-cliente>
        <div class="content">
            <try-our-most-popular></try-our-most-popular>
        </div>
    </div>
</template>
<script>
import navBarCliente from './nav-bar-cliente.vue';
import TryOurMostPopular from './try-our-most-popular.vue';
export default {

    components: {
        navBarCliente,
        TryOurMostPopular
    }
}
</script>
<style>


</style>