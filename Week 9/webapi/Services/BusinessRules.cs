public static class BusinessRules
{
    public static bool isSpecial(Student student) => 
        student.email_address.Contains("simpson");

}