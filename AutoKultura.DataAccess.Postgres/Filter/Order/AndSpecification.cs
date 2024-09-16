namespace AutoKultura.DataAccess.SqlServer.Filter.Order
{
    public class AndSpecification<T>(params Specification<T>[] items) : CompositeSpecification<T>(items)
    {
        public override bool IsSatisfied(T item)
        {
           return _specifications.All(spec => spec.IsSatisfied(item));
        }
    }
}
