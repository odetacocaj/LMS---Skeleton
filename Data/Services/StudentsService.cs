using LearningEnvironment2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Data.Services
{
    public class StudentsService : IStudentsService
    {
        private readonly AppDbContext _context;

        public StudentsService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var result =  await _context.Students.ToListAsync();
            return result;
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Student Update(int id, Student newStudent)
        {
            throw new NotImplementedException();
        }
    }
}
