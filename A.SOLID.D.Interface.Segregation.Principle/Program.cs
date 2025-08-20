using A.SOLID.D.Interface.Segregation.Principle.Printers;

namespace A.SOLID.D.Interface.Segregation.Principle;

class Program
{
    static void Main(string[] args)
    {
        #region Initialisation

        var random = new Random();
        var contents = new List<string> { "Apple", "Bananas", "Orange" };
        var content = contents[random.Next(contents.Count)];
        Console.WriteLine($"The content is {content}.");

        #endregion

        #region Printer with two interfaces

        var oldFashionedPrinter = new OldFashionedPrinter(content);
        Console.WriteLine($"The old fashioned printer: {oldFashionedPrinter.Print()}");
        Console.WriteLine($"The old fashioned printer: {oldFashionedPrinter.Fax()}.");

        #endregion

        #region Printer with all interfaces

        var multiplePrinter = new MultiplePrinter(content);
        Console.WriteLine($"The multiple printer: {multiplePrinter.Print()}");
        Console.WriteLine($"The multiple printer: {multiplePrinter.Fax()}.");
        Console.WriteLine($"The multiple printer: {multiplePrinter.Copy()}.");
        Console.WriteLine($"The multiple printer: {multiplePrinter.Scan()}.");

        #endregion
    }
}