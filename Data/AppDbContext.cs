using Microsoft.EntityFrameworkCore;
using EventManagerFunctional.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Event> Events { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>(entity =>
        {
            entity.ToTable("EVENT", "RM554867");  // Define o schema e a tabela

            entity.HasKey(e => e.Id);             // Define a chave primária

            entity.Property(e => e.Id)
                .HasColumnName("ID");

            entity.Property(e => e.Name)
                .HasColumnName("NAME")
                .IsRequired();

            entity.Property(e => e.EventDate)
                .HasColumnName("EVENT_DATE")
                .IsRequired();

            entity.Property(e => e.Location)
                .HasColumnName("LOCATION");

            entity.Property(e => e.Description)
                .HasColumnName("DESCRIPTION");
        });
    }
}
