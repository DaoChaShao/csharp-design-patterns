namespace A.SOLID.B.Open.And.Closed.Principle;

internal class SpecificationSize(Size size)
    : ISpecification<Product>
{
    private Size Size { get; } = size;

    public bool IsConsistent(Product product) => product.Size == Size;
}