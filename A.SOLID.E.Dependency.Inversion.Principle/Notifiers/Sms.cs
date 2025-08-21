namespace A.SOLID.E.Dependency.Inversion.Principle.Notifiers;

using A.SOLID.E.Dependency.Inversion.Principle.Interfaces;

internal class Sms : INotifier
{
    public void Notify(string name, string message)
        => Console.WriteLine($"Hello {name},\n{message}\nThis notification is send via SMS.");
}