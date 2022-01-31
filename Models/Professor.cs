using LearningEnvironment2.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Models
{
    public class Professor : IEntityBase
    {
        public int id { get; set; }

        [Display(Name="First Name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and 50 characters")]
        public string Name { get; set; }
        
        [Display(Name = "Last Name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last Name must be between 2 and 50 characters")]

        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Academic Grade")]
        public string AcademicGrade { get; set; }

        [Display(Name = "Field Of Study")]
        public string FieldOfStudy { get; set; }

        [Display(Name = "Specialization")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Field of Study must be between 3 and 100 characters")]
        public string Specialization { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage ="Picture required!")]
        public string Image { get; set; }

        //Relationships
        public List<Course> Courses { get; set; }

    }
}
