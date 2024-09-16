using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.View
{
    public class ViewPartOfTheCar
    {
        public Guid Id { get; set; }

        public Guid ServiseTypeId { get; set; }

        [DisplayName("Выполняемые работы")]
        public string NameServiceType { get; set; } = string.Empty;

        [DisplayName("Деталь автомобиля")]
        public string NamePartOfTheCar{ get; set; } = string.Empty;

        [DisplayName("Цена")]
        public decimal Price { get; set; }
    }
}
