

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class LinqMaterialForServiceEntity
    {
        public Guid Id { get; set; }
        public List<MaterialEntity> Materials { get; set; } = [];

        public List<ServiceTypeEntity> ServicesTypes { get; set; } = [];

    }
}
