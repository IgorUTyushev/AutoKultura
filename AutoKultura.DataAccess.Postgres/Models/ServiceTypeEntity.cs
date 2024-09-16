

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class ServiceTypeEntity
    {
        public Guid Id { get; set; }

        [DisplayName("Название услуги")]
        public string Title { get; set; } = string.Empty;

        public List<PartOfTheCarEntity> PartsOfTheCar { get; set; } = [];

        public List<LinqMaterialForServiceEntity> LinqMaterialsForServices { get; set; } = [];

    }
}
