using AutoKultura.DataAccess.SqlServer.View;

namespace AutoKultura.DataAccess.SqlServer.Filter.Order
{
    public class StatusOrderSpecification : Specification<ViewOrders>
    {
        private readonly string status;

        public StatusOrderSpecification(string status) => this.status = status;
        public override bool IsSatisfied(ViewOrders item)
        {           
            if (status.Equals("Выполненые"))
                return item.DateOfDeliveryOfTheOrder > DateTime.MinValue;
            else
                return item.DateOfDeliveryOfTheOrder == DateTime.MinValue;
        }
    }
}
