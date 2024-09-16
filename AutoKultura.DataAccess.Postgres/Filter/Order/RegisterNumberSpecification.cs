using AutoKultura.DataAccess.SqlServer.View;

namespace AutoKultura.DataAccess.SqlServer.Filter.Order
{
    public class RegisterNumberSpecification(string registerNumber) : Specification<ViewOrders>
    {
        private readonly string registerNumber = registerNumber.Replace(" ", "");

        //public RegisterNumberSpecification(string registerNumber)
        //{
        //    this.registerNumber = registerNumber.Replace(" ", "");
        //}

        public override bool IsSatisfied(ViewOrders item)
        {
            return item.RegisterNumber.ToUpper().Replace(" ", "").Contains(registerNumber.ToUpper(), StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
