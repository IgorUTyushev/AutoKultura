
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class HistoryOfTheChangesPriceServicesTypePartOfTheCarConfiguration : IEntityTypeConfiguration<HistoryOfTheChangesPriceServicesTypePartOfTheCarEntity>
    {
        public void Configure(EntityTypeBuilder<HistoryOfTheChangesPriceServicesTypePartOfTheCarEntity> builder)
        {
            builder
                .HasKey(h => h.Id);

            builder
                .HasOne(h => h.PartOfTheCar)
                .WithMany(s => s.HistoryOfTheChangesPriceServicesTypePartOfTheCar)
                .HasForeignKey(h => h.PartOfTheCarId);

            builder
                .Property(h => h.Price)
                .HasColumnType("decimal(10,2)");
        }
    }
}
