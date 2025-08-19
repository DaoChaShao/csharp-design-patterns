namespace A.SOLID.B.Open.And.Closed.Principle;

internal class Product(string name, Colour colour, Size size)
{
    private string Name { get; } = name;
    internal Colour Colour { get; } = colour;
    internal Size Size { get; } = size;

    public override string ToString()
    {
        return $"The {Name,-4}'s colour is {Colour,-6} and its size is {Size,-6}.";
    }
}