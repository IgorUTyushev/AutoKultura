
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class MeasureUnitConfiguration : IEntityTypeConfiguration<MeasureUnitEntity>
    {
        public void Configure(EntityTypeBuilder<MeasureUnitEntity> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasMany(mu => mu.Materials)
                .WithOne(m => m.MeasureUnit)
                .HasForeignKey(m => m.MeasureUnitId);
        }
    }
}
