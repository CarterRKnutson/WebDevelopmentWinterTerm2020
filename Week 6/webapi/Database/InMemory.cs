using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {     
        public static List<Student> Students = new List<Student> {
            new Student {
                Id = 1,
                StudentName = "Bart",
                EmailAddress = "bart.simpson@school.com"
            },
            new Student {
                Id = 2,
                StudentName = "Lisa",
                EmailAddress = "lisa.simpson@school.com"
            },
             new Student {
                Id = 3,
                StudentName = "Milhouse",
                EmailAddress = "milhouse.vanhauten@school.com"
            },
            new Student {
                Id = 4,
                StudentName = "Nelson",
                EmailAddress = "nelson.munce@school.com"
            }
        };
         public static List<Instructor> Instructors = new List<Instructor> {
            new Instructor {
                Id = 1,
                InstructorFirstName = "Amanda",
                 InstructorLastName = "Hugnkiss",
            },
             new Instructor {
                Id = 2,
                InstructorFirstName = "Edna",
                 InstructorLastName = "Krabopal",
            },
           new Instructor {
                Id = 3,
                InstructorFirstName = "Anita",
                 InstructorLastName = "Bath",
            }
        };
    }
}