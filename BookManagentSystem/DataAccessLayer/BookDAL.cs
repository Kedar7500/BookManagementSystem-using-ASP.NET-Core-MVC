using Entities;
using Repository;
using System.Data.SqlTypes;

namespace DataAccessLayer
{
    public class BookDAL
    {
        public List<Book> getAllBooks()
        {
            return BookRepository.AllBooks;
        }

        public bool AddBook(Book bk)
        {
            BookRepository.AllBooks.Add(bk);
            return true;
        }

    }
}