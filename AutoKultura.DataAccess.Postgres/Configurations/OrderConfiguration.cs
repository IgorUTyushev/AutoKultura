
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasOne(o => o.Vechicle)
                .WithMany(v => v.Orders)
                .HasForeignKey(o => o.VechicleId);

            builder
                .HasOne(o => o.PymentMethod)
                .WithMany(py => py.Orders)
                .HasForeignKey(o => o.PymentMethodId);

            builder
                .HasMany(o => o.RendersServices)
                .WithOne(rs => rs.Order)
                .HasForeignKey(rs => rs.OrderId);

            builder
                .Property(o => o.Price)
                .HasColumnType("decimal(10,2)");
        }
    }
}
