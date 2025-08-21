namespace A.SOLID.E.Dependency.Inversion.Principle.Services;

using A.SOLID.E.Dependency.Inversion.Principle.Interfaces;

internal class Book(INotifier notifier)
{
    private INotifier Notifier { get; } = notifier;

    public void Confirm(string name)
    {
        Notifier.Notify(name, "Congratulations! Your reservation is successful.");
    }
}