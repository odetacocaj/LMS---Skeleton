using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Models
{
    public class Faculty

    {
        public int id { get; set; }
        [Display(Name="Faculty Name")]
        public string Name { get; set; }

        [Display(Name = "Telephone Number")]
        public int Telephone { get; set; }

        [Display(Name = "Office Email")]
        public string Email { get; set; }
        //Relationships
        public List<Course> Courses { get; set; }
    }
}
