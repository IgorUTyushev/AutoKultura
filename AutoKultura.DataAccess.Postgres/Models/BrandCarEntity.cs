

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class BrandCarEntity
    {
        public Guid Id { get; set; }

        [DisplayName("Марка машины")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Модели")]
        public List<ModelCarEntity> ModelsCars { get; set; } = [];
    }

}
