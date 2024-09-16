
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class ModelCarConfiguration : IEntityTypeConfiguration<ModelCarEntity>
    {
        public void Configure(EntityTypeBuilder<ModelCarEntity> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasOne(mc => mc.BrandCar)
                .WithMany(bc => bc.ModelsCars)
                .HasForeignKey(bc => bc.BrandCarId);

            builder
                .HasOne(mc => mc.Bodywork)
                .WithMany(bw => bw.ModelsCars)
                .HasForeignKey(bw => bw.BodyworkId);

            builder
                .HasMany(mc => mc.Vechicles)
                .WithOne(v => v.ModelCar)
                .HasForeignKey(v => v.ModelCarId);
        }
    }
}
