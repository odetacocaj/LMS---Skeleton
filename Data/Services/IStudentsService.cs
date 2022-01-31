using LearningEnvironment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Data.Services
{
    public interface IStudentsService
    {
        Task<IEnumerable<Student>> GetAll();

        Student GetById(int id);

        void Add(Student student);

        Student Update(int id, Student newStudent);

        void Delete(int id);


    }
}
