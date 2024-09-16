
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class BrandCarConfiguration : IEntityTypeConfiguration<BrandCarEntity>
    {
        public void Configure(EntityTypeBuilder<BrandCarEntity> builder)
        {
            builder
                .HasKey(bc => bc.Id);

            builder
                .HasMany(bc => bc.ModelsCars)
                .WithOne(m => m.BrandCar)
                .HasForeignKey(mc => mc.BrandCarId);
        }
    }
}
