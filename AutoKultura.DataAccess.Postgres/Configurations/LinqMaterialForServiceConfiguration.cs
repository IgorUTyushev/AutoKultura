
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class LinqMaterialForServiceConfiguration : IEntityTypeConfiguration<LinqMaterialForServiceEntity>
    {
        public void Configure(EntityTypeBuilder<LinqMaterialForServiceEntity> builder)
        {
            builder.
               HasKey(l => l.Id);

            builder
                .HasMany(l => l.ServicesTypes)
                .WithMany(st => st.LinqMaterialsForServices);

            builder
                .HasMany(l => l.Materials)
                .WithMany(m => m.LinqsServices);
        }
    }
}
