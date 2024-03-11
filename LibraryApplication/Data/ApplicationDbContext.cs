using LibraryApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }
        public DbSet<Book> book { get; set; }
    }
}
