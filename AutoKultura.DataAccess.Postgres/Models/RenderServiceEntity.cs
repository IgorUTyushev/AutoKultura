

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class RenderServiceEntity
    {
        public Guid Id { get; set; }

        public Guid OrderId { get; set; }
        public OrderEntity? Order { get; set; }

        public Guid PartOfTheCarId { get; set; }
        public PartOfTheCarEntity? PartOfTheCar { get; set; }

        [DisplayName("Цена")]
        public decimal Price { get; set; } = 0;

        public List<UsedUpMaterialEntity> UsedUpMaterials { get; set; } = [];

        public List<LinqSpecialistForRenderServicesEntity> LinqSecialist {  get; set; } = [];

    }

}
