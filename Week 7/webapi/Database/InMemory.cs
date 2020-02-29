using System.Collections.Generic;

namespace Database
{
    public static class InMemory
    {     
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