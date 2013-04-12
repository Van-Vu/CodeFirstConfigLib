using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using CodeFirstConfigLib.Fluent;

namespace CodeFirstConfigLib.Convention.Infrastructure
{
    public class ConventionContext: DbContext
    {
        public ConventionContext(string connString)
            : base(connString)
        {}

        public DbSet<FluentUser> Users { get; set; }
        public DbSet<FluentDrivingLicense> DrivingLicenses { get; set; }
        public DbSet<FluentOrder> Orders { get; set; }
        public DbSet<FluentProduct> Products { get; set; }
    }
}
