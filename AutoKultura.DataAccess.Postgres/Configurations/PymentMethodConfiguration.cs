
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class PymentMethodConfiguration : IEntityTypeConfiguration<PymentMethodEntity>
    {
        public void Configure(EntityTypeBuilder<PymentMethodEntity> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasMany(pm => pm.Orders)
                .WithOne(o => o.PymentMethod)
                .HasForeignKey(o => o.PymentMethodId);
        }
    }
}
