using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.View
{
    public class ViewModelCar
    {
        public Guid IdModelCar { get; set; }

        public Guid IdBrandCar { get; set; }

        public Guid IdBodyWork { get; set; }

        [DisplayName("Марка")]
        public string NameBrandCar { get; set; } = string.Empty;

        [DisplayName("Модель")]
        public string NameModelCar { get; set; } = string.Empty;

        [DisplayName("Тип кузова")]
        public string NameBodyWork { get; set; } = string.Empty;

    }
}
