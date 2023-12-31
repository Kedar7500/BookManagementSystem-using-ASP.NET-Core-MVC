using DataAccessLayer;
using Entities;

namespace BusinessLogic
{
    public class BookBL
    {
        BookDAL bDal=new BookDAL();
        public List<Book> getAllBooks()
        {
            return bDal.getAllBooks();
        }

    }
}