using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ECTS { get; set; }

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
