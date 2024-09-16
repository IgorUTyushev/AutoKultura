
using AutoKultura.DataAccess.SqlServer.Configurations;
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace AutoKultura.DataAccess.SqlServer
{
    public class AutoKulturaDbContext : DbContext
    { 

        public DbSet<BodyworkEntity> Bodyworks { get; set; }

        public DbSet<BrandCarEntity> BrandsCars { get; set; }
        public DbSet<CompanyEntity> Company { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<HistoryOfTheChangePriceMaterialEntity> HistoryOfTheChangePriceMaterials { get; set; }
        public DbSet<HistoryOfTheChangesPriceServicesTypePartOfTheCarEntity> HistoryOfTheChangePriceServicesPartCar { get; set; }
        public DbSet<LinqMaterialForServiceEntity> LinqMaterialForServices { get; set; }
        public DbSet<LinqSpecialistForRenderServicesEntity> LinqSpecialistForRenderServices { get; set; }
        public DbSet<MaterialEntity> Materials { get; set; }
        public DbSet<MeasureUnitEntity> MeasureUnits { get; set; }
        public DbSet<ModelCarEntity> ModelsCars { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<PymentMethodEntity> PymentMethods { get; set; }
        public DbSet<RenderServiceEntity> RendersServices { get; set; }
        public DbSet<ServiceTypeEntity> ServicesTypes { get; set; }

        public DbSet<PartOfTheCarEntity> PartsOfTheCar { get; set; }
        public DbSet<SpecialistEntity> Specialists { get; set; }

        public DbSet<UsedUpMaterialEntity> UsedUpMaterials { get; set; }
        public DbSet<VechicleEntity> Vechicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ConnectionDB"].ConnectionString);
        }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BodyWorkConfiguration());
            modelBuilder.ApplyConfiguration(new BrandCarConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new HistoryOfTheChangePriceMaterialConfiguration());
            modelBuilder.ApplyConfiguration(new HistoryOfTheChangesPriceServicesTypePartOfTheCarConfiguration());
            modelBuilder.ApplyConfiguration(new LinqMaterialForServiceConfiguration());
            modelBuilder.ApplyConfiguration(new LinqSpecialistForRenderServicesConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialConfiguration());
            modelBuilder.ApplyConfiguration(new MeasureUnitConfiguration());
            modelBuilder.ApplyConfiguration(new ModelCarConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new PymentMethodConfiguration());
            modelBuilder.ApplyConfiguration(new RenderServiceConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SpecialistConfiguration());
            modelBuilder.ApplyConfiguration(new UsedUpMaterialConfiguration());
            modelBuilder.ApplyConfiguration(new VechicleConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
