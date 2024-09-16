using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AutoKultura.DataAccess.SqlServer.Filter.Order
{
    public class CustomerSpecification(string customerName) : Specification<ViewOrders>
    {
        private readonly string customerName = customerName.Replace(" ", "");

        public override bool IsSatisfied(ViewOrders item)
        {
            return item.NameCustomer.ToUpper().Contains(customerName.ToUpper(), StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
