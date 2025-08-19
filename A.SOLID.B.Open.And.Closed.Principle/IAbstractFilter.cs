namespace A.SOLID.B.Open.And.Closed.Principle;

internal interface IAbstractFilter<T>
{
    IEnumerable<T> Products(IEnumerable<T> items, ISpecification<T> specification);
}