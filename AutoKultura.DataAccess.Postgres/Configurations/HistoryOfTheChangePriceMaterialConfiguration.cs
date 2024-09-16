
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class HistoryOfTheChangePriceMaterialConfiguration : IEntityTypeConfiguration<HistoryOfTheChangePriceMaterialEntity>
    {
        public void Configure(EntityTypeBuilder<HistoryOfTheChangePriceMaterialEntity> builder)
        {
            builder
                .HasKey(h => h.Id);

            builder
                .HasOne(h => h.Material)
                .WithMany(m => m.HistoryOfTheChangesPriceMaterials)
                .HasForeignKey(h => h.MaterialId);

            builder
                .Property(h => h.Price)
                .HasColumnType("decimal(10,2)");
        }
    }
}
