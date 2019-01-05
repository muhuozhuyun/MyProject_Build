//import vue from 'vue';
//var data = { a: 1 }
var vm = new Vue({
    el: '#app',
    data: { a: 1 },
    created: function () {
        // `this` points to the vm instance
        console.log('a is: ' + this.a)
    },
    methods: {}
});