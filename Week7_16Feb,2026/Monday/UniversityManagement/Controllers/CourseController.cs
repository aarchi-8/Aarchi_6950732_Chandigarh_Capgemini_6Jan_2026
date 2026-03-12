using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UniversityManagement.Models;
using UniversityManagementSystem.Models;

namespace UniversityManagement.Controllers
{
    public class CourseController : Controller
    {
        private readonly UniversityContext _context;

        public CourseController(UniversityContext context)
        {
            _context = context;
        }

        // READ
        public IActionResult Index()
        {
            var courses = _context.Courses.ToList();
            return View(courses);
        }

        // CREATE (Form)
        public IActionResult Create()
        {
            return View();
        }

        // CREATE (Save)
        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(course);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        // EDIT (Form)
        public IActionResult Edit(int id)
        {
            var course = _context.Courses.Find(id);
            return View(course);
        }

        // EDIT (Update)
        [HttpPost]
        public IActionResult Edit(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // DELETE (Confirm)
        public IActionResult Delete(int id)
        {
            var course = _context.Courses.Find(id);
            return View(course);
        }

        // DELETE (Remove)
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var course = _context.Courses.Find(id);
            _context.Courses.Remove(course);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // DETAILS
        public IActionResult Details(int id)
        {
            var course = _context.Courses.Find(id);
            return View(course);
        }
    }
}