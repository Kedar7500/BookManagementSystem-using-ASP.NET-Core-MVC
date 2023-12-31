using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Publication { get; set; }
        public float? Price { get; set; }
        public char? BookType { get; set; }
        public DateTime? Created { get; set; }= DateTime.Now;
        public DateTime? Updated { get; set;}= DateTime.Now;


        public Book() { 

        }

        public Book(int bookId, string? title, string? author, string? publication, float? price, char? bookType, DateTime? created, DateTime? updated)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            Publication = publication;
            Price = price;
            BookType = bookType;
            Created = created;
            Updated = updated;
        }
    }
}
