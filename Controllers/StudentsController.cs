﻿using LearningEnvironment2.Data;
using LearningEnvironment2.Data.Services;
using LearningEnvironment2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentsService _service;

        public StudentsController(IStudentsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get : Students/Create
        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,LastName,Email,Age,AcademicYear,StudentStatus")]Student student) {
            if (!ModelState.IsValid) 
            {
                return View(student);
            }

             await _service.AddAsync(student);
            return RedirectToAction(nameof(Index));
        }

        //Get: Students/Details/1 (1 is id example)

        public async Task<IActionResult> Details(int id)
        {
            var studentDetails = await _service.GetByIdAsync(id);

            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
        }

        //Edit

        public async Task <IActionResult> Edit(int id)
        {
            var studentDetails = await _service.GetByIdAsync(id);
            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("id,Name,LastName,Email,Age,AcademicYear,StudentStatus")] Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }

            await _service.UpdateAsync(id,student);
            return RedirectToAction(nameof(Index));
        }
        // Students/Delete/1

        public async Task<IActionResult> Delete(int id)
        {
            var studentDetails = await _service.GetByIdAsync(id);
            if (studentDetails == null) return View("NotFound");
            return View(studentDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentDetails = await _service.GetByIdAsync(id);
            if (studentDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
         
            return RedirectToAction(nameof(Index));
        }

    }
}
