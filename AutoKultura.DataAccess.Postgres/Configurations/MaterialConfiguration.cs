
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class MaterialConfiguration : IEntityTypeConfiguration<MaterialEntity>
    {
        public void Configure(EntityTypeBuilder<MaterialEntity> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasOne(m => m.MeasureUnit)
                .WithMany(mu => mu.Materials)
                .HasForeignKey(mu => mu.MeasureUnitId);

            builder
                .HasMany(m => m.UsedUpMaterials)
                .WithOne(um => um.Material);

            builder
                .HasMany(m => m.HistoryOfTheChangesPriceMaterials)
                .WithOne(h => h.Material);

            builder
                .HasMany(m => m.LinqsServices)
                .WithMany(l => l.Materials);

            builder
                .Property(m => m.Count)
                .HasColumnType("decimal(10,3)") ;
        }
    }
}
