using TestApp.Models;
using Microsoft.EntityFrameworkCore;

namespace TestApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books {get;set;}
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}


