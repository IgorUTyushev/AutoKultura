
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class RenderServiceConfiguration : IEntityTypeConfiguration<RenderServiceEntity>
    {
        public void Configure(EntityTypeBuilder<RenderServiceEntity> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasOne(rs => rs.Order)
                .WithMany(o => o.RendersServices)
                .HasForeignKey(rs => rs.OrderId);

            builder
              .HasOne(rs => rs.PartOfTheCar)
              .WithMany(pc => pc.RendersServices)
              .HasForeignKey(rs => rs.PartOfTheCarId);

            builder
                .HasMany(rs => rs.UsedUpMaterials)
                .WithOne(m => m.RenderService)
                .HasForeignKey(m => m.RenderServiceId);

            builder
                .HasMany(rs => rs.LinqSecialist)
                .WithOne(l => l.RenderService);

            builder
                .Property(rs => rs.Price)
                .HasColumnType("decimal(10,2)");
        }
    }
}
