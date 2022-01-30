using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Models
{
    public class Faculty

    {
        public int id { get; set; }
        public string Name { get; set; }

        public int Telephone { get; set; }
        public string Email { get; set; }
        //Relationships
        public List<Course> Courses { get; set; }
    }
}
