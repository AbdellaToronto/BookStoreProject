using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookData;

namespace BookLib
{
    interface IBookRepository:IRepository<Book>
    {
        List<Book> GetBookByID();
        List<Book> GetBookByName();
        List<Book> GetAllBooks();
    }
}
