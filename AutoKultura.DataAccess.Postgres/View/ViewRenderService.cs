using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.View
{
    public class ViewRenderService
    {
        public Guid Id { get; set; }

        public Guid IdOrder { get; set; }

        [DisplayName("Выполненная работа")]
        public string NameServiceType { get; set; } = string.Empty;

        [DisplayName("Часть автомобиля")]
        public string PartOfTheCar { get; set; } = string.Empty;

        [DisplayName("Цена")]
        public decimal Price { get; set; }
    }
}
