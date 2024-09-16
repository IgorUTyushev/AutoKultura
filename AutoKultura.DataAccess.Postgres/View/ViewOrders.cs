using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.View
{
    public class ViewOrders
    {
        public Guid Id { get; set; }

        [DisplayName("Дата")]
        public DateTime DateOrder { get; set; }

        [DisplayName("Марка")]
        public string NameBrandCar { get; set; } = string.Empty;

        [DisplayName("Модель")]
        public string NameModelCar { get; set; } = string.Empty;

        [DisplayName("Рег. Номер")]
        public string RegisterNumber { get; set; } = string.Empty;

        [DisplayName("Клиент")]
        public string NameCustomer { get; set; } = string.Empty;

        [DisplayName("Дата сдачи работ")]
        public DateTime DateOfDeliveryOfTheOrder { get; set; }
    }
}
