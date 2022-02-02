using LearningEnvironment2.Data.Base;
using LearningEnvironment2.Data.ViewModels;
using LearningEnvironment2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Data.Services
{
    public class CoursesService: EntityBaseRepository<Course>,ICoursesService
    {
        private readonly AppDbContext _context;
        public CoursesService(AppDbContext context):base(context)
        {
            _context = context;
        }

        public async Task AddNewCourseAsync(NewCourseVM data)
        {
            var newCourse = new Course()
            {
                Name = data.Name,
                Description = data.Description,
                ECTS = data.ECTS,
                ImageURL = data.ImageURL,
                FacultyId = data.FacultyId,
                ProfessorId = data.ProfessorId

            };
           await _context.Courses.AddAsync(newCourse);
            await _context.SaveChangesAsync();
            
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            var courseDetails = _context.Courses
                .Include(c => c.Faculty)
                .Include(p => p.Professor)
                .Include(cs => cs.Course_Student).ThenInclude(s => s.Student)
                .FirstOrDefaultAsync(n => n.id == id);

            return await courseDetails;

        }

        public async Task<NewCourseDropdownsVM> GetNewCourseDropdownsValues()
        {
            var response = new NewCourseDropdownsVM()
            {
                Professors = await _context.Professors.OrderBy(n => n.Name).ToListAsync(),
                Faculties = await _context.Faculties.OrderBy(n => n.Name).ToListAsync()
            };
            
            return response;
        }

        public async Task UpdateCourseAsync(NewCourseVM data)
        {
            var dbCourse = await _context.Courses.FirstOrDefaultAsync(n => n.id == data.id);

            if (dbCourse !=null) {

                dbCourse.Name = data.Name;
                dbCourse.Description = data.Description;
                dbCourse.ECTS = data.ECTS;
                dbCourse.ImageURL = data.ImageURL;
                dbCourse.FacultyId = data.FacultyId;
                dbCourse.ProfessorId = data.ProfessorId;

               
               
                await _context.SaveChangesAsync();
            }
           
        }
    }
}
