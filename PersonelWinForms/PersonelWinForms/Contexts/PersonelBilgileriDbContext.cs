using Microsoft.EntityFrameworkCore;
using PersonelWinForms.Entities;

namespace PersonelWinForms.Contexts;

public partial class PersonelBilgileriDbContext : DbContext
{
    public PersonelBilgileriDbContext()
    {
    }

    public PersonelBilgileriDbContext(DbContextOptions<PersonelBilgileriDbContext> options)
        : base(options)
    {
    }


    public virtual DbSet<Maas> Maaslar { get; set; }

    public virtual DbSet<Personel> Personeller { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PersonelBilgileriDB;trusted_connection=true;trustservercertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       

        modelBuilder.Entity<Maas>(entity =>
        {
            entity.Property(e => e.Ucret).HasColumnType("money");
            entity.Property(e => e.Yil)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Personel).WithMany(p => p.Maas)
                .HasForeignKey(d => d.PersonelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Maas_Personel");
        });

        modelBuilder.Entity<Personel>(entity =>
        {
            entity.Property(e => e.Ad)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.DogumTarih).HasColumnType("date");
            entity.Property(e => e.KimlikNo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Soyad)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
