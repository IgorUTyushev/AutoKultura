

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class HistoryOfTheChangesPriceServicesTypePartOfTheCarEntity
    {
        public Guid Id { get; set; }

        [DisplayName("Дата изменения")]
        public DateTime DateChange { get; set; }

        [DisplayName("Цена")]
        public decimal Price { get; set; } = 0;

        public Guid PartOfTheCarId { get; set; }

        [DisplayName("Услуга")]
        public PartOfTheCarEntity? PartOfTheCar { get; set; }

    }

}
