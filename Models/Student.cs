using LearningEnvironment2.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Models
{
    public class Student :IEntityBase{

        [Key]
        public int id { get; set; }

        [Display(Name = "FirstName")]
        //[Required(ErrorMessage ="FirstName is required!")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="First Name must be between 2 and 50 characters")]
        public string Name { get; set; }

        [Display(Name = "LastName")]
        //[Required(ErrorMessage = "LastName is required!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Last Name must be between 2 and 50 characters")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        //[Required(ErrorMessage = "Email is required!")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = " Please provide a valid email!")]
        public string Email { get; set; }

        [Display(Name = "Age")]
        [Required(ErrorMessage = "Age is required!")]

        public int Age { get; set; }

        [Display(Name = "Academic Year")]
        [Required(ErrorMessage = "Academic Year is required!")]
        public int AcademicYear { get; set; }

        public static int StudentCount { get; set; }

        [Display(Name = "Status")]
        

        public bool StudentStatus { get; set; }

        
        //Relationships
        public List<Course_Student> Course_Student { get; set; }
    }
}
