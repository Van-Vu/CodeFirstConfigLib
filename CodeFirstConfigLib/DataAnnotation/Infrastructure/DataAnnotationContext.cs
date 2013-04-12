using System.Data.Entity;

namespace CodeFirstConfigLib.DataAnnotation.Infrastructure
{
    public class DataAnnotationContext: DbContext
    {
        public DbSet<DAUser> Users { get; set; }
        public DbSet<DADrivingLicense> DrivingLicenses { get; set; }
        public DbSet<DAOrder> Orders { get; set; }
        public DbSet<DAProduct> Products { get; set; }
        public DbSet<DACategory> Categories { get; set; }

        public DataAnnotationContext(string connString): base(connString)
        {
        }
    }
}
