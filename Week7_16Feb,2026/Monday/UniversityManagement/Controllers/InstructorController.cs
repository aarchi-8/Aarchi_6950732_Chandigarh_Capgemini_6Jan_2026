using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using UniversityManagement.Models;
using UniversityManagementSystem.Models;

namespace UniversityManagement.Controllers
{
    public class InstructorController : Controller
    {
        private readonly UniversityContext _context;

        public InstructorController(UniversityContext context)
        {
            _context = context;
        }

        // READ
        public IActionResult Index()
        {
            var instructors = _context.Instructors
                .Include(i => i.Department)
                .ToList();

            return View(instructors);
        }

        // CREATE (Form)
        public IActionResult Create()
        {
            ViewBag.Departments = new SelectList(_context.Departments, "DepartmentId", "Name");
            return View();
        }

        // CREATE (Save)
        [HttpPost]
        public IActionResult Create(Instructor instructor)
        {
            if (ModelState.IsValid)
            {
                _context.Instructors.Add(instructor);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Departments = new SelectList(_context.Departments, "DepartmentId", "Name");
            return View(instructor);
        }

        // EDIT
        public IActionResult Edit(int id)
        {
            var instructor = _context.Instructors.Find(id);

            ViewBag.Departments = new SelectList(_context.Departments, "DepartmentId", "Name", instructor.DepartmentId);

            return View(instructor);
        }

        [HttpPost]
        public IActionResult Edit(Instructor instructor)
        {
            _context.Instructors.Update(instructor);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            var instructor = _context.Instructors
                .Include(i => i.Department)
                .FirstOrDefault(i => i.InstructorId == id);

            return View(instructor);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var instructor = _context.Instructors.Find(id);

            _context.Instructors.Remove(instructor);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // DETAILS
        public IActionResult Details(int id)
        {
            var instructor = _context.Instructors
                .Include(i => i.Department)
                .FirstOrDefault(i => i.InstructorId == id);

            return View(instructor);
        }
    }
}