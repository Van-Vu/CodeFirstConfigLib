using System.Data.Entity;

namespace CodeFirstConfigLib.Convention.Infrastructure
{
    public class ConventionContext: DbContext
    {
        public ConventionContext(string connString)
            : base(connString)
        {}

        public DbSet<User> Users { get; set; }
        public DbSet<DrivingLicense> DrivingLicenses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
