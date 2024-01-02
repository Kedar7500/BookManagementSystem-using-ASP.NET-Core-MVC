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

        public bool Update(Book bk)
        {
            return bDal.Update(bk);

        }
        public Book? getBook(int id)
        {
            return bDal.GetBook(id);

        }

        public Book? Delete(int BookId)
        {
            return bDal.Delete(BookId);

        }

    }
}