using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.View
{
    public class ViewUsedUpMaterial
    {
        public Guid IdUsedUpMaterial { get; set; }

        [DisplayName("Название материала")]
        public string NameMaterial { get; set; } = string.Empty;
        [DisplayName("Единица измерения")]
        public string NameMeasureUnit { get; set; } = string.Empty;

        [DisplayName("Количество")]
        public decimal Quantity { get; set; }
    }
}
