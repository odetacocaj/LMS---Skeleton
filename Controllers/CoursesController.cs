using LearningEnvironment2.Data;
using LearningEnvironment2.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningEnvironment2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LearningEnvironment2.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICoursesService _service;

        public CoursesController(ICoursesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allCourses = await _service.GetAllAsync(n => n.Faculty);
            return View(allCourses);
        }

        public async Task<IActionResult> Filter(string searchString)
        {
            var allCourses = await _service.GetAllAsync(n => n.Faculty);
            if (!string.IsNullOrEmpty(searchString)) {
                var filteredResult = allCourses.Where(n => n.Name.Contains(searchString) || n.Description.Contains(searchString)).ToList();
                return View("Index", filteredResult);
            }
            return View("Index",allCourses);
        }

        //Get : Courses/Details/1

        public async Task<IActionResult> Details(int id) {
            var courseDetail = await _service.GetCourseByIdAsync(id);
            return View(courseDetail);
        }

        //Get: Courses/Create

        public async Task<IActionResult> Create() {
            var couseDropdownsData = await _service.GetNewCourseDropdownsValues();

            ViewBag.FacultyId = new SelectList(couseDropdownsData.Faculties, "id", "Name");
            ViewBag.ProfessorId = new SelectList(couseDropdownsData.Professors, "id", "Name") ;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewCourseVM course) {

            if (!ModelState.IsValid) 
            {
                var couseDropdownsData = await _service.GetNewCourseDropdownsValues();
                ViewBag.FacultyId = new SelectList(couseDropdownsData.Faculties, "id", "Name");
                ViewBag.ProfessorId = new SelectList(couseDropdownsData.Professors, "id", "Name");
                return View(course);
            }
            await _service.AddNewCourseAsync(course);
            return RedirectToAction(nameof(Index));
        }

        //Get: Courses/Edit/1

        public async Task<IActionResult> Edit(int id)
        {
            var courseDetails = await _service.GetCourseByIdAsync(id);
            if (courseDetails == null) return View("NotFound");

            var response = new NewCourseVM()
            {
                id = courseDetails.id,
                Name = courseDetails.Name,
                Description = courseDetails.Description,
                ECTS = courseDetails.ECTS,
                ImageURL = courseDetails.ImageURL,
                FacultyId = courseDetails.FacultyId,
                ProfessorId = courseDetails.ProfessorId

            };
            var couseDropdownsData = await _service.GetNewCourseDropdownsValues();

            ViewBag.FacultyId = new SelectList(couseDropdownsData.Faculties, "id", "Name");
            ViewBag.ProfessorId = new SelectList(couseDropdownsData.Professors, "id", "Name");
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,NewCourseVM course)
        {
            if (id != course.id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var couseDropdownsData = await _service.GetNewCourseDropdownsValues();
                ViewBag.FacultyId = new SelectList(couseDropdownsData.Faculties, "id", "Name");
                ViewBag.ProfessorId = new SelectList(couseDropdownsData.Professors, "id", "Name");
                return View(course);
            }
            await _service.UpdateCourseAsync(course);
            return RedirectToAction(nameof(Index));
        }

    }
}
