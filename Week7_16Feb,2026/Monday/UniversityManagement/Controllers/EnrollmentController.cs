using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using UniversityManagement.Models;
using UniversityManagementSystem.Models;

namespace UniversityManagement.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly UniversityContext _context;

        public EnrollmentController(UniversityContext context)
        {
            _context = context;
        }

        // READ
        public IActionResult Index()
        {
            var enrollments = _context.Enrollments
                .Include(e => e.Student)
                .Include(e => e.Course)
                .ToList();

            return View(enrollments);
        }

        // CREATE (Form)
        public IActionResult Create()
        {
            ViewBag.Students = new SelectList(_context.Students, "StudentId", "FullName");
            ViewBag.Courses = new SelectList(_context.Courses, "CourseId", "Title");
            return View();
        }

        // CREATE (Save)
        [HttpPost]
        public IActionResult Create(Enrollments enrollment)
        {
            if (ModelState.IsValid)
            {
                _context.Enrollments.Add(enrollment);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Students = new SelectList(_context.Students, "StudentId", "FullName");
            ViewBag.Courses = new SelectList(_context.Courses, "CourseId", "Title");

            return View(enrollment);
        }

        // EDIT
        public IActionResult Edit(int id)
        {
            var enrollment = _context.Enrollments.Find(id);

            ViewBag.Students = new SelectList(_context.Students, "StudentId", "FullName", enrollment.StudentId);
            ViewBag.Courses = new SelectList(_context.Courses, "CourseId", "Title", enrollment.CourseId);

            return View(enrollment);
        }

        [HttpPost]
        public IActionResult Edit(Enrollments enrollment)
        {
            _context.Enrollments.Update(enrollment);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // DELETE
        public IActionResult Delete(int id)
        {
            var enrollment = _context.Enrollments
                .Include(e => e.Student)
                .Include(e => e.Course)
                .FirstOrDefault(e => e.EnrollmentId == id);

            return View(enrollment);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var enrollment = _context.Enrollments.Find(id);

            _context.Enrollments.Remove(enrollment);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // DETAILS
        public IActionResult Details(int id)
        {
            var enrollment = _context.Enrollments
                .Include(e => e.Student)
                .Include(e => e.Course)
                .FirstOrDefault(e => e.EnrollmentId == id);

            return View(enrollment);
        }
    }
}