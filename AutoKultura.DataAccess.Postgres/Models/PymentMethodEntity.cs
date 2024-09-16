

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class PymentMethodEntity
    {
        public Guid Id { get; set; }

        [DisplayName("Способ оплаты")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Способ оплаты по умолчанию")]
        public bool MethodDefault { get; set; } = false;

        public List<OrderEntity> Orders { get; set; } = [];

    }
}
