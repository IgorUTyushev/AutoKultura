using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;

namespace AutoKultura.DataAccess.SqlServer.Filter.Order
{
    public class BrandCarSpecification(string brandCarName) : Specification<ViewOrders>
    {
        private readonly string brandCarName = brandCarName.Replace(" ", "");

        public override bool IsSatisfied(ViewOrders item)
        {
            return item.NameBrandCar.ToUpper().Contains(brandCarName.ToUpper(), StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
