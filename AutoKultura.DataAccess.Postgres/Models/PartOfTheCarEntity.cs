

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class PartOfTheCarEntity
    {
        public Guid Id { get; set; }

        public Guid ServiceTypeId { get; set; } = Guid.Empty;

        public ServiceTypeEntity? ServiceType { get; set; }

        [DisplayName("Часть автомобиля")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Цена на услуги")]
        public List<HistoryOfTheChangesPriceServicesTypePartOfTheCarEntity> HistoryOfTheChangesPriceServicesTypePartOfTheCar { get; set; } = [];

        public List<RenderServiceEntity> RendersServices { get; set; } = [];

    }
}
