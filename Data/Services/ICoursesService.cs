using LearningEnvironment2.Data.Base;
using LearningEnvironment2.Data.ViewModels;
using LearningEnvironment2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Data.Services
{
    public interface ICoursesService:IEntityBaseRepository<Course>
    {
        Task<Course> GetCourseByIdAsync(int id);
        Task<NewCourseDropdownsVM> GetNewCourseDropdownsValues();
        Task AddNewCourseAsync(NewCourseVM data);

        Task UpdateCourseAsync(NewCourseVM data);
    }
}
