using Microsoft.AspNetCore.Mvc;
using System.Linq;
using UniversityManagement.Models;
using UniversityManagementSystem.Models;

namespace UniversityManagement.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly UniversityContext _context;

        public DepartmentController(UniversityContext context)
        {
            _context = context;
        }

        // READ (List all departments)
        public IActionResult Index()
        {
            var departments = _context.Departments.ToList();
            return View(departments);
        }

        // CREATE (Form)
        public IActionResult Create()
        {
            return View();
        }

        // CREATE (Save)
        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(department);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(department);
        }

        // EDIT (Form)
        public IActionResult Edit(int id)
        {
            var department = _context.Departments.Find(id);
            return View(department);
        }

        // EDIT (Update)
        [HttpPost]
        public IActionResult Edit(Department department)
        {
            _context.Departments.Update(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // DELETE (Confirm)
        public IActionResult Delete(int id)
        {
            var department = _context.Departments.Find(id);
            return View(department);
        }

        // DELETE (Remove)
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var department = _context.Departments.Find(id);
            _context.Departments.Remove(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // DETAILS
        public IActionResult Details(int id)
        {
            var department = _context.Departments.Find(id);
            return View(department);
        }
    }
}