using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Linq;
using System.Reflection;

namespace CodeFirstConfigLib.DataAnnotation.Infrastructure
{
    public class DataAnnotationContext: DbContext
    {
        public DbSet<DAUser> Users { get; set; }
        public DbSet<DADrivingLicense> DrivingLicenses { get; set; }
        public DbSet<DAOrder> Orders { get; set; }
        public DbSet<DAProduct> Products { get; set; }
        public DbSet<DACategory> Categories { get; set; }
        public DbSet<DAContact> Contacts { get; set; }
        public DbSet<DANationality> Nationalities { get; set; }
        public DbSet<DAProductInStock> ProductInStocks { get; set; }
        public DbSet<DAProductOutOfStock> ProductOutOfStocks { get; set; }

        public DataAnnotationContext(string connString): base(connString)
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions
            // TODO: remove all convention
            //MethodInfo method;
            //method = typeof(ConventionsConfiguration).GetMethod("Remove");
            //foreach (var convention in Assembly.GetCallingAssembly()
            //  .GetTypes()
            //  .Where(t => t.Namespace == "System.Data.Entity.ModelConfiguration.Conventions" || t.Namespace == "System.Data.Entity.Infrastructure")
            //  .Where(t => t.GetInterface("IConvention", false) != null && !t.IsInterface && !t.IsAbstract))
            //{
            //    method.MakeGenericMethod(convention).Invoke(modelBuilder.Conventions, null);
            //}
        }

        
    }
}
