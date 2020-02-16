function validate()
{
    document.getElementById("usernameError").style.visibility = 'hidden'
    document.getElementById("passwordError").style.visibility = 'hidden'

    let username = document.getElementById('user').value
    let password = document.getElementById('pswrd').value

    if (username == "") 
    {
        document.getElementById("usernameError").style.visibility = 'visible'
    }

    if (password == "") 
    {
        document.getElementById("passwordError").style.visibility = 'visible'
    }

    

}