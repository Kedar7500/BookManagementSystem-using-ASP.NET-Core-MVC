using Entities;
namespace Repository
{
    public static class BookRepository
    {

        public static List<Book> AllBooks = new List<Book>()
        {
            new Book {BookId=101,Title="ShrimanYogi",Author="Ranjit Desai",Publication="Mehta",Price=625.50f,BookType='E'},
            new Book {BookId=102,Title="SambhajiRaja",Author="Sadashiv Shivde",Publication="Pushakr",Price=699.90f,BookType='H'},
            new Book {BookId=103,Title="Raja ShivChatrapati",Author="BabaSaheb PuranDare",Publication="Mulakshar",Price=1250.50f,BookType='H'}
        };

    }
}