using AutoKultura.DataAccess.SqlServer.Models;
using AutoKultura.DataAccess.SqlServer.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKultura.DataAccess.SqlServer.Filter.Order
{
    public class OrdersFilter : Ifilter<ViewOrders>
    {
        public IEnumerable<ViewOrders> Filter(IEnumerable<ViewOrders> items, Specification<ViewOrders> spec)
        {
            foreach (var item in items)
            {
                if (spec.IsSatisfied(item))
                    yield return item;
            }   
        }
    }
}
