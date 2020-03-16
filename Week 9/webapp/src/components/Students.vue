<template>
    <div>
     <h2 class='tables'>Students</h2>
        <table>
            <thead>
                <tr>
                    <th>Email</th>
                    <th>StudentID</th>
                </tr>
            </thead>
            <tbody>
                <tr v-for="student in students" :key="student.student_id">
                    <td>{{ student.email_address }}</td>
                    <td>{{ student.student_id}}</td>
                </tr>
            </tbody>
        </table>
    </div>  
</template>

<script>
    import Vue from 'vue';
    export default {
        name: 'Students',
        
        data () {
            return {
                students: [],
                operation: 'list',
                email_address: undefined,
                student_id: undefined,
                apiServer: process.env.VUE_APP_API_SERVER
            }
        },
        methods: {
            getStudents: function() {
                let url = `http://${this.apiServer}/api/student`;
                Vue.axios.get(url).then(
                    (response) => {
                        this.students = response.data;
                    },
                    (error) => {
                        console.log(error)
                    }
                );
            }
        },
         mounted() {
            this.getStudents();
            this.operation = 'list';
        }
    }
      
</script>


<style scoped>

.tables { 
    background-color: black; 
    color: red; 
    padding: 8px; 
}
</style>
        