using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookData;

namespace BookLib
{
    class MockRepository:IBookRepository,IAuthorRepository,IBorrowerRepository
    {

        List<Book> bookList;
        List<Author> auList;
        List<Borrower> boList;

        public MockRepository()
        {
            bookList.Add(new Book(554, "I Win", "Awesome Publishing", 4, "Action", "Detroit", "This book has comments"));
            auList.Add(new Author("John", "Jacob", "Awesome Author"));
        }


        public List<Book> GetBookByID()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBookByName()
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllBooks()
        {
            return bookList;
        }

        public void Add(Book item)
        {
            throw new NotImplementedException();
        }

        public void Remove(Book item)
        {
            throw new NotImplementedException();
        }

        public Book GetByID(int bID)
        {
            throw new NotImplementedException();
        }

        public void GetAuthorByName()
        {
            throw new NotImplementedException();
        }

        public void GetAllPersons()
        {
            throw new NotImplementedException();
        }

        public void GetBorrowerByName()
        {
            throw new NotImplementedException();
        }
    }
}
