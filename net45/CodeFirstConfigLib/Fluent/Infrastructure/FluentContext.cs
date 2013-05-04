using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using CodeFirstConfigLib.Fluent.Mapping;

namespace CodeFirstConfigLib.Fluent.Infrastructure
{
    public class FluentContext: DbContext
    {
        public DbSet<FluentCategory> Categories { get; set; }
        public DbSet<FluentContact> Contacts { get; set; }
        public DbSet<FluentDrivingLicense> DrivingLicenses { get; set; }
        public DbSet<FluentNationality> Nationalities { get; set; }
        public DbSet<FluentOrder> Orders { get; set; }
        public DbSet<FluentProduct> Products { get; set; }
        public DbSet<FluentProductInStock> ProductInStocks { get; set; }
        public DbSet<FluentProductOutOfStock> ProductOutOfStocks { get; set; }
        public DbSet<FluentReservation> Reservations { get; set; }
        public DbSet<FluentUser> Users { get; set; }
        public DbSet<FatEntityForMultiTables> FatEntityForMultiTables { get; set; }

        //public FluentContext()
        //{}

        protected FluentContext(DbContextFactory dbContext)
        {}

        public FluentContext(string connString):base(connString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new ContactMapping());
            modelBuilder.Configurations.Add(new DrivingLicenseMapping());
            modelBuilder.Configurations.Add(new NationalityMapping());
            modelBuilder.Configurations.Add(new OrderMapping());
            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Configurations.Add(new ProductInStockMapping());
            modelBuilder.Configurations.Add(new ProductOutOfStockMapping());
            modelBuilder.Configurations.Add(new ReservationMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new FatEntityForMultiTablesMapping());

        }
    }
}
