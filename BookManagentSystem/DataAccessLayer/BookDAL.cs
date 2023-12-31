using Entities;
using Repository;

namespace DataAccessLayer
{
    public class BookDAL
    {
        public List<Book> getAllBooks()
        {
            return BookRepository.AllBooks;
        }

    }
}