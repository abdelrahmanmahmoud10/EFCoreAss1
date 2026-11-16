using EFCoreAss1.Entities;
using Microsoft.EntityFrameworkCore;


namespace EFCoreAss1.Context
{
    public class AppDbContext: DbContext
    {
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Assignment01;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        DbSet<Author> Authors { get; set; }

        DbSet<Book> Books { get; set; }

        DbSet<Category> Categories { get; set; }


    }
}
