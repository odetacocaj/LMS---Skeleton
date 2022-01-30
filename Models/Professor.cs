using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Models
{
    public class Professor 
    {
        public int id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }
        public string AcademicGrade { get; set; }
        public string FieldOfStudy { get; set; }
        public string Specialization { get; set; }

        public string Image { get; set; }

        //Relationships
        public List<Course> Courses { get; set; }

    }
}
