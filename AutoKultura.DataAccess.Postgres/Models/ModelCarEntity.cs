

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class ModelCarEntity
    {
        public Guid Id { get; set; }

        [DisplayName("Название модели")]
        public string Name { get; set; } = string.Empty;

        public Guid BrandCarId { get; set; }

        [DisplayName("Марка")]
        public BrandCarEntity? BrandCar { get; set; }

        public Guid BodyworkId { get; set; }
        [DisplayName("Тип кузова")]
        public BodyworkEntity? Bodywork { get; set;}

        [DisplayName("транспортные средства")]
        public List<VechicleEntity> Vechicles { get; set; } = [];
    }

}
