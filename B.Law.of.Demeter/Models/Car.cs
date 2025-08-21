namespace B.Law.of.Demeter.Models;

internal class Car
{
    private Engine Engine { get; } = new Engine();

    internal string Wheel() => Engine.Start();
}