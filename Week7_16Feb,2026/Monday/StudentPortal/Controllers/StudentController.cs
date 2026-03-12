using Microsoft.AspNetCore.Mvc;
using StudentPortal.Models;
using StudentPortal.Services;
using System.Linq;

public class StudentController : Controller
{
    private readonly StudentDBContext _context;
    private readonly IRequestLogService _logService;

    public StudentController(StudentDBContext context, IRequestLogService logService)
    {
        _context = context;
        _logService = logService;
    }

    // Display students
    public IActionResult Index()
    {
        var students = _context.Students.ToList();

        ViewBag.Logs = _logService.GetLogs();

        return View(students);
    }

    // GET: Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Create
    [HttpPost]
    public IActionResult Create(Student student)
    {
        _context.Students.Add(student);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}