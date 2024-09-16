
using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class VechicleEntity
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }
        public CustomerEntity? Customer { get; set; }

        public Guid ModelCarId { get; set; }
        public ModelCarEntity? ModelCar { get; set; }

        [DisplayName("Гос. номер")]
        public string RegisterNumberCar { get; set; } = string.Empty;

        public List<OrderEntity> Orders { get; set; } = [];
    }
}
