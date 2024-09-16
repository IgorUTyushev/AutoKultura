

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class UsedUpMaterialEntity
    {
        public Guid Id { get; set; }

        public Guid MaterialId { get; set; }
        public MaterialEntity? Material { get; set; }

        [DisplayName("Количество материала")]
        public decimal QuantityMaterial { get; set; } = 0;

        public Guid RenderServiceId { get; set; }

        public RenderServiceEntity? RenderService { get; set; } 
    }

}
