<template>
    <div>
     <h2 class='tables'>Instructors</h2>
        <table>
            <thead>
                <tr>
                    <th>Last Name</th>
                    <th>Middle Initial</th>
                    <th>First Name</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="instructor in instructors" v-bind:key="instructor">
                    <td>{{ instructor.lastName }}</td>
                    <td>{{ instructor.middleinit }}</td>
                    <td>{{ instructor.firstName }}</td>
                </tr>
            </tbody>
        </table>
    </div>   
</template>


<script>
    export default {
        name: 'Instructors',
        mounted() {
            this.instructors = getInstructors();
        },
        data () {
            return {
                instructors: []
            }
        }
    }
    function getInstructors() {
        return JSON.parse(instructors);
    }
    var instructors = '[{"firstName": "Elizabeth", "middleinit": "J", "lastName": "Hoover"}, {"firstName": "Edna", "middleinit": "P", "lastName": "Krabopal"}]';
</script>

<style scoped>
.tables { 
    background-color: black; 
    color: red; 
    padding: 8px; 
}
</style>