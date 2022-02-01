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
    public class AdminsController : Controller
    {
        private readonly IAdminsService _service;

        public AdminsController(IAdminsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allAdmins = await _service.GetAllAsync();
            return View(allAdmins);
        }

        //Get : Admins/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,LastName,Email,Certification,Image")] Admin admin)
        {
            if (!ModelState.IsValid)
            {
                return View(admin);
            }

            await _service.AddAsync(admin);
            return RedirectToAction(nameof(Index));
        }
        //Get: Admins/Details/1 (1 is id example)

        public async Task<IActionResult> Details(int id)
        {
            var adminDetails = await _service.GetByIdAsync(id);

            if (adminDetails == null) return View("NotFound");
            return View(adminDetails);
        }

        //Get : Admins/Edit/1

        public async Task<IActionResult> Edit(int id)
        {
            var adminDetails = await _service.GetByIdAsync(id);
            if (adminDetails == null) return View("NotFound");
            return View(adminDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("id,Name,LastName,Email,Certification,Image")] Admin admin)
        {
            if (!ModelState.IsValid)
            {
                return View(admin);
            }

            await _service.UpdateAsync(id, admin);
            return RedirectToAction(nameof(Index));
        }
        // Admins/Delete/1

        public async Task<IActionResult> Delete(int id)
        {
            var adminDetails = await _service.GetByIdAsync(id);
            if (adminDetails == null) return View("NotFound");
            return View(adminDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var adminDetails = await _service.GetByIdAsync(id);
            if (adminDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
