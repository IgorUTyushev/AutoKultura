
using AutoKultura.DataAccess.SqlServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutoKultura.DataAccess.SqlServer.Configurations
{
    public class BodyWorkConfiguration: IEntityTypeConfiguration<BodyworkEntity>
    {
        public void Configure(EntityTypeBuilder<BodyworkEntity> builder)
        {
            builder
                .HasKey(e => e.Id);

            builder
                .HasMany(bw => bw.ModelsCars)
                .WithOne(mc => mc.Bodywork)
                .HasForeignKey(mc => mc.BodyworkId);
        } 
    }
}
