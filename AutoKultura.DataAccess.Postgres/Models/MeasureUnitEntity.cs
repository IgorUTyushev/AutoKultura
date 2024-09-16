

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class MeasureUnitEntity
    {
        public Guid Id { get; set; }

        [DisplayName("Ед. измер.")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("материалы")]
        public List<MaterialEntity> Materials { get; set; } = [];
    }

}
