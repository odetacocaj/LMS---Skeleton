using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Models
{
    public class Student { 

        [Key]
        public int id { get; set; }
    public string Name { get; set; }

    public string LastName { get; set; }
    public string Email { get; set; }
    
        public int Age { get; set; }

        public int AcademicYear { get; set; }

        public static int StudentCount { get; set; }

        public bool StudentStatus { get; set; }

        
        //Relationships
        public List<Course_Student> Course_Student { get; set; }
    }
}
