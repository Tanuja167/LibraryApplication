using LibraryApplication.Models;

namespace LibraryApplication.Repository
{
    public interface IBookRepo
    {
        IEnumerable<Book> GetAllBooks();

        public int AddBook(Book book);

        public Book GetBookById(int id);

        
        public int DeleteBook(int id);

        IEnumerable<Book> GetBooksByAuthor(string author);

    }
}
