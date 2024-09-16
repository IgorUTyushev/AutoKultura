

using System.ComponentModel;

namespace AutoKultura.DataAccess.SqlServer.Models
{
    public class OrderEntity
    {
        public Guid Id { get; set; }

        [DisplayName("Дата заказа")]
        public DateTime DateOrder { get; set; }

        public Guid VechicleId { get; set; }
        [DisplayName("транспортное средство")]
        public VechicleEntity? Vechicle { get; set; }

        [DisplayName("Дата сдачи заказа")]
        public DateTime DateOfDeliveryOfTheOrder { get; set; }

        [DisplayName("Цена")]
        public Decimal Price { get; set; } = 0;
        
        public Guid PymentMethodId { get; set; }

        [DisplayName("Способ оплаты")]
        public PymentMethodEntity? PymentMethod { get; set; }

        [DisplayName("Оказанные услуги")]
        public List<RenderServiceEntity> RendersServices { get; set; } = [];
    }

}
