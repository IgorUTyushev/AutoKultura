namespace AutoKultura.DataAccess.SqlServer.Filter.Order
{
    public abstract class CompositeSpecification<T>(params Specification<T>[] items) : Specification<T>
    {
        protected readonly Specification<T>[] _specifications = items;

        //protected CompositeSpecification(params Specification<T>[] items)
        //{
        //    _specifications = items;
        //}
    }
    public abstract class Specification<T>
    {
        public abstract bool IsSatisfied(T item);
    }
}
