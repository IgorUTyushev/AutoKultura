

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class BodyworkEntity
    {
        public Guid Id { get; set; }

        [DisplayName("Тип кузова")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Модели машин")]
        public List<ModelCarEntity> ModelsCars { get; set; } = [];
    }

}
