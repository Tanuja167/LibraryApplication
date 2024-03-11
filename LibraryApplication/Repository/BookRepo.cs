using LibraryApplication.Data;
using LibraryApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApplication.Repository
{
    public class BookRepo : IBookRepo
    {

        ApplicationDbContext context;
        public BookRepo(ApplicationDbContext context)
        {
            this.context = context;
        }


        public IEnumerable<Book> GetAllBooks()
        {
            var result = context.book.ToList();
            return result;
        }

        public int AddBook(Book book)
        {
            context.book.Add(book);
            int result = context.SaveChanges();
            return result;

        }

        public Book GetBookById(int id)
        {
            var result = context.book.Where(x => x.Bookid == id).SingleOrDefault();
            return result;
        }

        public IEnumerable<Book> GetBooksByAuthor(string author)
        {
            var result = from o in context.book
                         where o.Author.Contains(author) || o.Bookname.Contains(author)
                         select o;
            return result;
        }

        public int DeleteBook(int id)
        {
            int res = 0;

            var result = context.book.Where(x => x.Bookid == id).FirstOrDefault();
            if(result != null)
            {
                context.book.Remove(result);
                res = context.SaveChanges();
            }
            return res;
        }

        

       

      
    }
}
