namespace AutoKultura.DataAccess.SqlServer.Filter.Order
{
    public interface Ifilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, Specification<T> spec);
    }
}
