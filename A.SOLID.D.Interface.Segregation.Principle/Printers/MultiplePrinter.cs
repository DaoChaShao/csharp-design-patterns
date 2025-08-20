using A.SOLID.D.Interface.Segregation.Principle.Interfaces;

namespace A.SOLID.D.Interface.Segregation.Principle.Printers;

internal class MultiplePrinter(string content) : IPrint, IFax, ICopy, IScan
{
    private string Content { get; } = content;

    public string Print(string content) => $"The {content} has been PRINTED.";
    public string Fax(string content) => $"The {content} has been FAXED.";
    public string Copy(string content) => $"The {content} has been COPIED.";
    public string Scan(string content) => $"The {content} has been SCANNED.";

    internal string Print() => Print(Content);
    internal string Fax() => Fax(Content);
    internal string Copy() => Copy(Content);
    internal string Scan() => Scan(Content);
}