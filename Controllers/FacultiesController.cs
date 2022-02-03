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
    public class FacultiesController : Controller
    {
        private readonly IFacultiesService _service;

        public FacultiesController(IFacultiesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allFaculties = await _service.GetAllAsync();
            return View(allFaculties);
        }

        //Get: Faculties/Create

        public IActionResult Create() {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,Telephone,Email")]Faculty faculty) {
            if (!ModelState.IsValid) return View(faculty);
            await _service.AddAsync(faculty);
            return RedirectToAction(nameof(Index));
        }

        //Get: Faculties/Details/1

        public async Task<IActionResult> Details(int id)
        {
            var facultyDetails = await _service.GetByIdAsync(id);
            if (facultyDetails == null) return View("NotFound");

            return View(facultyDetails);
        }
        //Edit

        public async Task<IActionResult> Edit(int id)
        {
            var facultyDetails = await _service.GetByIdAsync(id);
            if (facultyDetails == null) return View("NotFound");
            return View(facultyDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name,Telephone,Email")] Faculty faculty)
        {
            if (!ModelState.IsValid)
            {
                return View(faculty);
            }

            await _service.UpdateAsync(id, faculty);
            return RedirectToAction(nameof(Index));
        }

        //Edit

        public async Task<IActionResult> Edit(int id)
        {
            var facultyDetails = await _service.GetByIdAsync(id);
            if (facultyDetails == null) return View("NotFound");
            return View(facultyDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name,Telephone,Email")] Faculty faculty)
        {
            if (!ModelState.IsValid)
            {
                return View(faculty);
            }

            await _service.UpdateAsync(id, faculty);
            return RedirectToAction(nameof(Index));
        }


        //Get: Faculties/Delete/1

        public async Task<IActionResult> Delete(int id)
        {
            var facultyDetails = await _service.GetByIdAsync(id);
            if (facultyDetails == null) return View("NotFound");

            return View(facultyDetails);
        }

        [HttpPost,ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            var facultyDetails = await _service.GetByIdAsync(id);
            if (facultyDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
