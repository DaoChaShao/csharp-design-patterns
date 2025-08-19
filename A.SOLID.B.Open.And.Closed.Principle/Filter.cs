namespace A.SOLID.B.Open.And.Closed.Principle;

internal class Filter
    : IAbstractFilter<Product>
{
    public IEnumerable<Product> Products(IEnumerable<Product> items, ISpecification<Product> specification)
    {
        // Method I
        foreach (var item in items)
        {
            if (specification.IsConsistent(item))
            {
                yield return item;
            }
        }

        // Method II
        // return items.Where(item => specification.IsConsistent(item));
    }
}