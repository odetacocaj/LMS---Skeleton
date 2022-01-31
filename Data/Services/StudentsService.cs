using LearningEnvironment2.Data.Base;
using LearningEnvironment2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Data.Services
{
    public class StudentsService : EntityBaseRepository<Student>,IStudentsService
    {
       
        public StudentsService(AppDbContext context) : base(context)
        { }
       
    }
}
