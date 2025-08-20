namespace A.SOLID.B.Open.And.Closed.Principle;

internal class SpecificationAnd
    : ISpecification<Product>
{
    private ISpecification<Product> First { get; }
    private ISpecification<Product> Second { get; }

    internal SpecificationAnd(ISpecification<Product> first, ISpecification<Product> second)
    {
        First = first;
        Second = second;
    }

    public bool IsConsistent(Product item)
    {
        return First.IsConsistent(item) && Second.IsConsistent(item);
    }
}