using System.Collections.Generic;
using Microsoft.Extensions.Logging;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRespository;
    
    public StudentService(IStudentRepository studentRespository)
    {
        _studentRespository = studentRespository;
    }

    public List<StudnetViewModel> GetAllStudents()
    {
        var studentViewModels = new List<StudnetViewModel>();

        foreach(var student in _studentRespository.GetAllStudents())
        {
            studentViewModels.Add(new StudnetViewModel {
                StudentId = student.student_id,
                Email = student.email_address,
                Special = BusinessRules.isSpecial(student)
            });
        }

        return studentViewModels;
    }
}
