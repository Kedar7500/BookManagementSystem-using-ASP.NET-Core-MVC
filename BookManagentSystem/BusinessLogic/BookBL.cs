using DataAccessLayer;
using Entities;
using Repository;

namespace BusinessLogic
{
    public class BookBL
    {
        BookDAL bDal=new BookDAL();
        public List<Book> getAllBooks()
        {
            return bDal.getAllBooks();
        }

        public bool AddBook(Book bk)
        {
           bool result=bDal.AddBook(bk);
            return result;
        }

    }
}