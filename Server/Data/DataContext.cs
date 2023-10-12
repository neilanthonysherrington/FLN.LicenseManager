using Microsoft.EntityFrameworkCore;

namespace FLN.LicenseManager.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<User>? Users { get; set; }
        public DbSet<License>? Licenses { get; set; }
    }
}
