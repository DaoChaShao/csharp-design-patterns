namespace A.SOLID.A.Single.Responsibility.Principle;

internal class Journal
{
    private Dictionary<int, string> Dairy { get; } = new();
    private int RecordCount { get; set; } = 0;

    internal int DictionaryCount => Dairy.Count;

    internal Dictionary<int, string> Record(string record)
    {
        var dateAndTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        Dairy[++RecordCount] = $"{dateAndTime} {record}";
        return Dairy;
    }

    internal void Remove(Journal journal, int recordId)
    {
        Dairy.Remove(recordId);
    }

    public override string ToString()
    {
        return string.Join(Environment.NewLine, Dairy.Select(kvp => $"{kvp.Key}: {kvp.Value}"));
    }
}