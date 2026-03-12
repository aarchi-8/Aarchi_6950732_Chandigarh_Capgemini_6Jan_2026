using LibraryManagement.Models;
using System.Collections.Generic;

namespace LibraryManagement.Repositories
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
    }
}
