using Microsoft.AspNetCore.Mvc;
using LibraryManagement.Repositories;

namespace LibraryManagement.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookRepository _repository;

        public BooksController(IBookRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var books = _repository.GetAllBooks();
            return View(books);
        }

        public IActionResult Details(int id)
        {
            var book = _repository.GetBookById(id);

            if (book == null)
                return NotFound();

            return View(book);
        }
    }
}