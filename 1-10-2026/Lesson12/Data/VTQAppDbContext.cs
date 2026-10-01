using Microsoft.EntityFrameworkCore;
using VTQNetCoreCrud.Models;

namespace VTQNetCoreCrud.Data
{
    public class VTQAppDbContext : DbContext
    {
        public VTQAppDbContext(DbContextOptions<VTQAppDbContext> options) : base(options) { }

        public DbSet<VTQCategory> Categories { get; set; }
        public DbSet<VTQProduct> Products { get; set; }
    }
}
