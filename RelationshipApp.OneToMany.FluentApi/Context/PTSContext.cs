// See https://aka.ms/new-console-template for more information
using Microsoft.EntityFrameworkCore;

public class PTSContext : DbContext
{
    public DbSet<Personel> Personels { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Task> Tasks { get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-ATVPBPS;Database=PTSApp6;Integrated Security=true;Encrypt=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Personel>()
                    .HasOne(x => x.Department)
                    .WithMany(x => x.Personels)
                    .HasForeignKey(x => x.DepartmentId);
    }
}
