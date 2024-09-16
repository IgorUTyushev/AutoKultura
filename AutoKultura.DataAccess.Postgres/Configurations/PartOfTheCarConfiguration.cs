
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class PartOfTheCarConfiguration : IEntityTypeConfiguration<PartOfTheCarEntity>
    {
        public void Configure(EntityTypeBuilder<PartOfTheCarEntity> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasMany(pc => pc.RendersServices)
                .WithOne(rs => rs.PartOfTheCar)
                .HasForeignKey(rs => rs.PartOfTheCarId);

            builder
                .HasMany(st => st.HistoryOfTheChangesPriceServicesTypePartOfTheCar)
                .WithOne(h => h.PartOfTheCar)
                .HasForeignKey(h => h.PartOfTheCarId); 

            builder
                .HasOne(pc => pc.ServiceType)
                .WithMany(st => st.PartsOfTheCar)
                .HasForeignKey(pc => pc.ServiceTypeId);
        }
    }
}
