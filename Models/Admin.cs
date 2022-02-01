using LearningEnvironment2.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Models
{
    public class Admin: IEntityBase
    {

    
         public int id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Certification")]

        public string Certifications { get; set; }

        [Display(Name = "Profile Picture")]
        public string Image { get; set; }
    }
}

