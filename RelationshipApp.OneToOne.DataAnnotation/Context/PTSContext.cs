

using Microsoft.EntityFrameworkCore;

public class PTSContext : DbContext
{
    public DbSet<Personel> Personels { get; set; }
    public DbSet<PersonelAddress> PersonelAddresses { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-ATVPBPS;Database=PTSApp2;Integrated Security=true;Encrypt=False");
    }
}
