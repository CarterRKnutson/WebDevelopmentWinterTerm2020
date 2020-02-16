var instructors = '{"instructors": [\
    {"fname": "First Name", "minit": "Middle Initial", "lname": "Last Name"},\
    {"fname": "Ivan", "minit": "P", "lname": "Freely"},\
    {"fname": "Allan", "minit": "L", "lname": "Caholic"},\
    {"fname": "Olive", "minit": "R", "lname": "Klozoff"},\
    {"fname": "Bea", "minit": "O", "lname": "Problem"},\
    {"fname": "Amand", "minit": "A", "lname": "Huginkiss"}]}'

function getinstructorArray()
{
    return JSON.parse(instructors);
}

function displayInstructors(data)
{
    var tableList = "";
    for(i = 0; i < data.length; i++)
    {
        var fname = data[i].fname;
        var minit = data[i].minit;
        var lname = data[i].lname;

        tableList += "<tr><td>" + fname + "</td><td>" + minit + "</td><td>" + lname + "</td>";

        document.getElementById("instructor-list").innerHTML = tableList;

    }
}

function populateInstructors()
{
    var data = getinstructorArray();
    displayInstructors(data.instructors);

}