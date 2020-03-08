using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;
public class StudentServiceTests
{
    private StudentService _studentService; // System Under Test (SUT)
    private IStudentRepository _studentRepository; // Mock

    [SetUp]
    public void Setup()
    {
        _studentRepository = A.Fake<IStudentRepository>();

        _studentService = new StudentService(_studentRepository);
    }

    [Test]
    public void ShouldNotReturnSpecialStudent()
    {
        // Arrange (Given)
          A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    student_id = 1,
                    email_address = "milhouse.vanhauten@oit.edu"
                },
                new Student {
                    student_id = 2,
                    email_address = "nelson.munce@oit.edu"
                }
                
            }
        );

        // Act (When)
         var studentViewModels = _studentService.GetAllStudents();

        // Assert (NUnit Assertions) (Then)
        Assert.That(studentViewModels.Any(pdto => pdto.Special), Is.EqualTo(false));

        // Assert (FluentAssertions) (Then)
        studentViewModels.Any(pdto => pdto.Special).Should().BeFalse();
    }

    [Test]
    public void ShouldReturnSpecialStudent()
    {
        // Arrange
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    student_id = 1,
                    email_address = "bart.simpson@oit.edu"
                },
                new Student {
                    student_id = 2,
                    email_address = "nelson.munce@oit.edu"
                }
                
            }
        );

        // Act
        var studentViewModels = _studentService.GetAllStudents();

        // Assert (FluentAssertions)
        studentViewModels.Single(pdto => pdto.Special).StudentId.Should().Be(1);
    }
}