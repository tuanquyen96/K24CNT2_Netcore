using Microsoft.EntityFrameworkCore;
using VTQ2410900066_exam.Models;

namespace VTQ2410900066_exam.Data;

public class VTQDataSqlServer : DbContext
{
    public VTQDataSqlServer(DbContextOptions<VTQDataSqlServer> options) : base(options) { }

    public DbSet<VTQStudent> VTQStudents => Set<VTQStudent>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VTQStudent>(entity =>
        {
            entity.ToTable("VTQStudent");
            entity.HasKey(x => x.Id);
            entity.Property(x => x.VTQName).HasMaxLength(100).IsUnicode(true).IsRequired();
            entity.Property(x => x.VTQGender).HasMaxLength(10).IsUnicode(true);
            entity.Property(x => x.VTQEmail).HasMaxLength(120).IsUnicode(true);
            entity.Property(x => x.VTQPhone).HasMaxLength(20).IsUnicode(true);
        });
    }
}
