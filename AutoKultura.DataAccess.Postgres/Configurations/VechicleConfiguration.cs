
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class VechicleConfiguration : IEntityTypeConfiguration<VechicleEntity>
    {
        public void Configure(EntityTypeBuilder<VechicleEntity> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasOne(v => v.Customer)
                .WithMany(c => c.Vechicles)
                .HasForeignKey(v => v.CustomerId);

            builder
                .HasOne(v => v.ModelCar)
                .WithMany(mc => mc.Vechicles)
                .HasForeignKey(v => v.ModelCarId);

            builder
                .HasMany(v => v.Orders)
                .WithOne(o => o.Vechicle)
                .HasForeignKey(o => o.VechicleId);
        }
    }
}
