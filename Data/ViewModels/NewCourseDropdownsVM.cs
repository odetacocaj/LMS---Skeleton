using LearningEnvironment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Data.ViewModels
{
    public class NewCourseDropdownsVM
    {
        public NewCourseDropdownsVM()
        {
            Professors = new List<Professor>();
            Faculties = new List<Faculty>();
        }
        public List<Professor> Professors { get; set; }

        public List<Faculty> Faculties { get; set; }
    }
}
