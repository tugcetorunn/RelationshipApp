// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

public class LibraryContext : DbContext
{
    public DbSet<Book> Books { get; set;}
    public DbSet<Author> Authors { get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-ATVPBPS;Database=PTSApp8;Integrated Security=true;Encrypt=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cross>()
                    .HasKey(x => new {x.BookId, x.AuthorId});
    }
}
