
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class UsedUpMaterialConfiguration : IEntityTypeConfiguration<UsedUpMaterialEntity>
    {
        public void Configure(EntityTypeBuilder<UsedUpMaterialEntity> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasOne(um => um.RenderService)
                .WithMany(rs => rs.UsedUpMaterials)
                .HasForeignKey(um => um.RenderServiceId);

            builder
                .HasOne(um => um.Material)
                .WithMany(m => m.UsedUpMaterials)
                .HasForeignKey(um => um.MaterialId);

            builder
                .Property(h => h.QuantityMaterial)
                .HasColumnType("decimal(10,2)");
        }
    }
}
