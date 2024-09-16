
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class ServiceTypeConfiguration : IEntityTypeConfiguration<ServiceTypeEntity>
    {
        public void Configure(EntityTypeBuilder<ServiceTypeEntity> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasMany(bw => bw.PartsOfTheCar)
                .WithOne(pc => pc.ServiceType)
                .HasForeignKey(pc => pc.ServiceTypeId);            

            builder
                .HasMany(st => st.LinqMaterialsForServices)
                .WithMany(l => l.ServicesTypes);
        }
    }
}
