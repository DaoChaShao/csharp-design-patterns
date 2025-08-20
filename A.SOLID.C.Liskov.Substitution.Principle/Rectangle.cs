namespace A.SOLID.C.Liskov.Substitution.Principle;

internal class Rectangle(int width, int height) : Shape
{
    protected virtual int Width { get; } = width;
    protected virtual int Height { get; } = height;

    internal override int Area() => Width * Height;
}