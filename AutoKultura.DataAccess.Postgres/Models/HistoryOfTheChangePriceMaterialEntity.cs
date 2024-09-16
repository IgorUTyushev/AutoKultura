

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class HistoryOfTheChangePriceMaterialEntity
    {
        public Guid Id { get; set; }

        [DisplayName("Дата изменения")]
        public DateTime DateChange { get; set; }

        [DisplayName("Цена")]
        public decimal Price { get; set; } = 0;

        public Guid MaterialId { get; set; }

        [DisplayName("Материал")]
        public MaterialEntity? Material{ get; set; }

    }

}
