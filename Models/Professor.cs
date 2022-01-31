using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Models
{
    public class Professor 
    {
        public int id { get; set; }

        [Display(Name="First Name")]
        public string Name { get; set; }
        
        [Display(Name = "Last Name")]

        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Academic Grade")]
        public string AcademicGrade { get; set; }

        [Display(Name = "Field Of Study")]
        public string FieldOfStudy { get; set; }

        [Display(Name = "Specialization")]
        public string Specialization { get; set; }

        [Display(Name = "Profile Picture")]
        public string Image { get; set; }

        //Relationships
        public List<Course> Courses { get; set; }

    }
}
