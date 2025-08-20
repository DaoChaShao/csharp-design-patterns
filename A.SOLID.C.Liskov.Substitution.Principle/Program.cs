namespace A.SOLID.C.Liskov.Substitution.Principle;

class Program
{
    static void Main(string[] args)
    {
        #region Initialisation

        var random = new Random();
        var side = random.Next(1, 11);

        #endregion

        #region Square inherits Rectangle

        var squareRectangle = new SquareFromRectangle(side);
        Console.WriteLine(
            $"The area of the square that inherits the Rectangle class with side {side} is {squareRectangle.Area()}"
        );

        #endregion

        #region Square inherits Shape

        var squareShape = new SquareFromShape(side);
        Console.WriteLine(
            $"The area of the square that inherits the Shape class with side {side} is {squareShape.Area()}"
        );

        #endregion
    }
}