namespace A.SOLID.C.Liskov.Substitution.Principle;

internal class SquareFromRectangle : Rectangle
{
    private int Side { get; }

    internal SquareFromRectangle(int side) : base(side, side) => Side = side;

    internal override int Area() => Side * Side;
}