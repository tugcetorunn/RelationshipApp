

using Microsoft.EntityFrameworkCore;

public class PTSContext : DbContext
{
    public DbSet<Personel> Personels { get; set; }
    public DbSet<PersonelAddress> PersonelAddresses { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-ATVPBPS;Database=PTSApp3;Integrated Security=true;Encrypt=False");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PersonelAddress>()
                    .HasKey(x => x.PersonelAddressId);

        modelBuilder.Entity<Personel>()
                    .HasOne(p => p.PersonelAddress)
                    .WithOne(a => a.Personel)
                    .HasForeignKey<PersonelAddress>(x => x.PersonelAddressId); //bu komutla personeladdressid nin 
                                                                               //primary key özelliğini ezmiş
                                                                               //oluyoruz. o yüzden bir de onu 
                                                                               //tanımlamamız gerek.
    }
}
