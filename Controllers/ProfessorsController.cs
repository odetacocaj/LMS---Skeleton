using LearningEnvironment2.Data;
using LearningEnvironment2.Data.Services;
using LearningEnvironment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Controllers
{
    public class ProfessorsController : Controller
    {
        private readonly IProfessorsService _service;

        public ProfessorsController(IProfessorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProfessors = await _service.GetAllAsync();
            return View(allProfessors);
        }

        //GET : professors/details/1

        public async Task<IActionResult> Details(int id)
        {
            var professorDetails = await _service.GetByIdAsync(id);
            if (professorDetails == null) return View("NotFound");

            return View(professorDetails);
        }

        //GET : professors/create
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,LastName,Email,AcademicGrade,FieldOfStudy,Specialization,Image")] Professor professor) {
            if (!ModelState.IsValid) return View(professor);
            await _service.AddAsync(professor);
            return RedirectToAction(nameof(Index));
        }
    }
}
