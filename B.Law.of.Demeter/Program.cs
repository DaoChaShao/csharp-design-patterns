namespace B.Law.of.Demeter;

using B.Law.of.Demeter.Models;

class Program
{
    static void Main(string[] args)
    {
        #region LoD

        var driver = new Driver();
        var car = new Car();
        Console.WriteLine(driver.Drive(car));

        #endregion
    }
}