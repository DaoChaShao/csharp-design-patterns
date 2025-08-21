namespace B.Law.of.Demeter.Models;

internal class Driver
{
    internal string Drive(Car car) => car.Wheel();
}