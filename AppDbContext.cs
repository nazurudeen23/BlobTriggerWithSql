using Microsoft.EntityFrameworkCore;

namespace BlobWithSql.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<FileRecords> FileRecords { get; set; }
    }
}
