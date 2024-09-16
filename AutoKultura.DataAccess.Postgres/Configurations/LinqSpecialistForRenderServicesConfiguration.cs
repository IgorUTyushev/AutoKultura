
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class LinqSpecialistForRenderServicesConfiguration : IEntityTypeConfiguration<LinqSpecialistForRenderServicesEntity>
    {
        public void Configure(EntityTypeBuilder<LinqSpecialistForRenderServicesEntity> builder)
        {
            builder.
               HasKey(l => l.Id);

            builder
                .HasOne(l => l.RenderService)
                .WithMany(rs => rs.LinqSecialist)
                .HasForeignKey(l => l.RenderServiceId);

            builder
                .HasOne(l => l.Specialist)
                .WithMany(s => s.LinqsRenderServices)
                .HasForeignKey(l => l.SpecialistId);
        }
    }
}
