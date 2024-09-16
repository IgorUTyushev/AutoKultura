using AutoKultura.DataAccess.SqlServer.View;

namespace AutoKultura.DataAccess.SqlServer.Filter.Order
{
    public class ModelCarSpecification : Specification<ViewOrders>
    {
        private readonly string modelCarName;

        public ModelCarSpecification(string modelCarName)
        {
            this.modelCarName = modelCarName.Replace(" ", ""); ;
        }
        public override bool IsSatisfied(ViewOrders item)
        {
            return item.NameModelCar.ToUpper().Contains(modelCarName.ToUpper(), StringComparison.CurrentCultureIgnoreCase);
        }
    }

    public class DateOrderSpecification : Specification<ViewOrders>
    {
        private readonly DateTime date;
        
        private readonly bool onWithFlag;//true - дата с , false - дата по

        public DateOrderSpecification(DateTime date, int onWithflag)
        {
            this.date = date;

            if (onWithflag == -1)
                this.onWithFlag = false;
            else
                this.onWithFlag = true;
        }
        public override bool IsSatisfied(ViewOrders item)
        {
            if(onWithFlag)
                return item.DateOrder >= date;
            else
                return item.DateOrder <= date;
        }
    }
}
