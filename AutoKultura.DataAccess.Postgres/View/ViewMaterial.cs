using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.View
{
    public class ViewMaterial
    {
        public Guid IdMaterial { get; set; }

        public Guid IdMeasureUnite { get; set; }
        [DisplayName("Название материала")]
        public string NameMaterial { get; set; } = string.Empty;
        [DisplayName("Единица измерения")]
        public string NameMeasureUnit { get; set; } = string.Empty;

        [DisplayName("Количество")]
        public decimal Count { get; set; }

        [DisplayName("Цена")]
        public decimal Price { get; set; }
    }
}
