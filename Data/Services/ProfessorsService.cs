using LearningEnvironment2.Data.Base;
using LearningEnvironment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Data.Services
{
    public class ProfessorsService:EntityBaseRepository<Professor>,IProfessorsService
    {
        public ProfessorsService(AppDbContext context) : base(context)
        {

        }
    }
}
