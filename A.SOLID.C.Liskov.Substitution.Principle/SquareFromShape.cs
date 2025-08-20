namespace A.SOLID.C.Liskov.Substitution.Principle;

internal class SquareFromShape : Shape
{
    private int Side { get; }

    internal SquareFromShape(int side) => Side = side;

    internal override int Area() => Side * Side;
}