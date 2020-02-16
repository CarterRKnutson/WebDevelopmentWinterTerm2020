var students = '{"students": [\
    {"studentID": "Student ID", "email": "Email Address"},\
    {"studentID": 1234, "email": "1234@oit.edu"},\
    {"studentID": 1235, "email": "1235@oit.edu"},\
    {"studentID": 1236, "email": "1236@oit.edu"},\
    {"studentID": 1237, "email": "1237@oit.edu"},\
    {"studentID": 1238, "email": "1238@oit.edu"}]}'

function getstudentarray()
{
    return JSON.parse(students);
}

function displayStudents(data)
{
    var tableList = "";
    for(i = 0; i < data.length; i++)
    {
        var studentID = data[i].studentID;
        var email = data[i].email;

        tableList += "<tr><td>" + studentID + "</td><td>" + email + "</td>";

        document.getElementById("student-list").innerHTML = tableList;

    }
}

function populateStudents()
{
    var data = getstudentarray();
    displayStudents(data.students);

}