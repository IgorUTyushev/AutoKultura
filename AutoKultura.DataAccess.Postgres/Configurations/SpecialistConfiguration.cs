
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class SpecialistConfiguration : IEntityTypeConfiguration<SpecialistEntity>
    {
        public void Configure(EntityTypeBuilder<SpecialistEntity> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasMany(s => s.LinqsRenderServices)
                .WithOne(l => l.Specialist);
        }
    }
}
