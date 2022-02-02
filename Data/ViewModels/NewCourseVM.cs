using LearningEnvironment2.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Models
{
    public class NewCourseVM 
    {

        public int id { get; set; }

        [Display(Name = "Name")]

        public string Name { get; set; }

        [Display(Name = "Description")]

        public string Description { get; set; }

        [Display(Name = "ECTS")]

        public int ECTS { get; set; }

        [Display(Name = "Cover Photo")]

        public string ImageURL { get; set; }
        //Relationships


        public List<int> StudentIds { get; set; }

        //Faculty
        [Display(Name = "Select a Faculty")]
        [Required(ErrorMessage ="Faculty is required!")]
        public int FacultyId { get; set; }

        [Display(Name = "Select a lecturer")]
        [Required(ErrorMessage = "Lecturer/Professor is required!")]


        public int ProfessorId { get; set; }
       


    }
}
