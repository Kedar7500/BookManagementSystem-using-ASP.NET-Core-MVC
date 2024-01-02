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

        public bool Update(Book bk)
        {
            foreach (var book in BookRepository.AllBooks)
            {
                if(book.BookId == bk.BookId)
                {
                    book.Title = bk.Title;
                    book.Author = bk.Author;
                    book.Publication = bk.Publication;  
                    book.Price = bk.Price;
                    book.BookType = bk.BookType;    
                    book.Updated=bk.Updated;
                    return true;

                }  
            }
            return false;

        }

        public Book? GetBook(int id)
        {
            Book? bk=BookRepository.AllBooks.Where(b=>b.BookId==id).FirstOrDefault();
            return bk;
        }

        public Book? Delete(int BookId)
        {
            Book? bk=BookRepository.AllBooks.Where(b=>b.BookId == BookId).FirstOrDefault();
            if (bk != null)
            {
                BookRepository.AllBooks.Remove(bk);
            }
            return bk;
        }

    }
}