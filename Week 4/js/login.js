function validate()
{
    document.getElementById("usernameError").style.visibility = 'hidden'
    document.getElementById("passwordError").style.visibility = 'hidden'

    var username = document.getElementById('user').value
    var password = document.getElementById('pswrd').value

    if (username == "") 
    {
        document.getElementById("usernameError").style.visibility = 'visible'
    }

    if (password == "") 
    {
        document.getElementById("passwordError").style.visibility = 'visible'
    }

    

}