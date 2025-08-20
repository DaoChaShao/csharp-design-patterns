using A.SOLID.D.Interface.Segregation.Principle.Interfaces;

namespace A.SOLID.D.Interface.Segregation.Principle.Printers;

public class OldFashionedPrinter(string content) : IPrint, IFax
{
    private string Content { get; } = content;

    // Implement the interface methods of IPrint and IFax
    public string Print(string content) => $"The {content} has been PRINTED.";
    public string Fax(string content) => $"The {content} has been FAXED.";

    // Provide convenience methods that call the interface implementations using the internal Content
    internal string Print() => Print(Content);
    internal string Fax() => Fax(Content);
}