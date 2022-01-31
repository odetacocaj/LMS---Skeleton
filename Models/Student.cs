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

        [Display(Name = "FirstName")]
        public string Name { get; set; }

        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Age")]

        public int Age { get; set; }

        [Display(Name = "Academic Year")]
        public int AcademicYear { get; set; }

        public static int StudentCount { get; set; }

        [Display(Name = "Status")]

        public bool StudentStatus { get; set; }

        
        //Relationships
        public List<Course_Student> Course_Student { get; set; }
    }
}
