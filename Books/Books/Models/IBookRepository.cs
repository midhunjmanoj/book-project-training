using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Models
{
    public interface IBookRepository
    {
        List<Book> GetAllBook();
        Book GetBookById(string Bookid);
        Book AddBook(Book book);
        void DeleteBook(int BookId);
        void UpdataBook(Book book);

    }
}
