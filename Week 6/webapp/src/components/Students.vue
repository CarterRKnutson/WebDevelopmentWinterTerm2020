<template>
    <div>
     <h2 class='tables'>Students</h2>
        <table>
            <thead>
                <tr>
                    <th>Last Name</th>
                    <th>First Name</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students" v-bind:key="student">
                    <td>{{ student.lastName }}</td>
                    <td>{{ student.firstName }}</td>
                </tr>
            </tbody>
        </table>
    </div>  
</template>

<script>
    export default {
        name: 'Students',
        mounted() {
            this.students = getStudents();
        },
        data () {
            return {
                students: []
            }
        }
    }
    function getStudents() {
        return JSON.parse(students);
    }
    var students = '[{"firstName": "Bart", "lastName": "Simpson"}, {"firstName": "Lisa", "lastName": "Simpson"}]';
</script>


<style scoped>
.tables { 
    background-color: black; 
    color: red; 
    padding: 8px; 
}
</style>
