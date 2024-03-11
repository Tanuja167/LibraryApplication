using LibraryApplication.Models;
using LibraryApplication.Repository;

namespace LibraryApplication.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepo repo;

       

        public BookService(IBookRepo repo)
        {
            this.repo = repo;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return repo.GetAllBooks();
        }
        public int AddBook(Book book)
        {
            return repo.AddBook(book);
        }

        public Book GetBookById(int id)
        {
            return repo.GetBookById(id);
        }

        public int DeleteBook(int id)
        {
            return repo.DeleteBook(id);
        }

        public IEnumerable<Book> GetBooksByAuthor(string author)
        {
            return repo.GetBooksByAuthor(author);
        }
    }
}
