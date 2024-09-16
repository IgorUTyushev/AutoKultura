

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class MaterialEntity
    {
        public Guid Id { get; set; }

        [DisplayName("Название материала")]
        public string Name { get; set; } = string.Empty;

        public decimal Count { get; set; }
        public Guid MeasureUnitId { get; set; }

        [DisplayName("Единица измерения")]
        public MeasureUnitEntity? MeasureUnit { get; set; }

        [DisplayName("Использованные материалы")]
        public List<UsedUpMaterialEntity> UsedUpMaterials { get; set; } = [];

        [DisplayName("Цена на материалы")]
        public List<HistoryOfTheChangePriceMaterialEntity> HistoryOfTheChangesPriceMaterials { get; set; } = [];

        public List<LinqMaterialForServiceEntity> LinqsServices { get; set; } = [];

    }

}
