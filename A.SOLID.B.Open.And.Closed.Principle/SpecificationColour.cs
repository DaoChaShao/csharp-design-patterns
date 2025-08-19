namespace A.SOLID.B.Open.And.Closed.Principle;

internal class SpecificationColour(Colour colour)
    : ISpecification<Product>
{
    private Colour Colour { get; } = colour;
    public bool IsConsistent(Product product) => product.Colour == Colour;
}