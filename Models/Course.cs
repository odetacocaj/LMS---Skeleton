using LearningEnvironment2.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Models
{
    public class Course: IEntityBase
    {
        [Key]
       // [Column("id")]
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
        public List<Course_Student> Course_Student { get; set; }

        //Faculty
        public int FacultyId { get; set; }
        [ForeignKey("FacultyId")]
        public Faculty Faculty { get; set; }

        //Professor
      
        public int ProfessorId { get; set; }
        [ForeignKey("ProfessorId")]
        public Professor Professor { get; set; }


    }
}
