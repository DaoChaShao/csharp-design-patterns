using System.IO.Compression;

namespace A.SOLID.A.Single.Responsibility.Principle;

class Program
{
    static void Main(string[] args)
    {
        #region OOP

        var journal = new Journal();
        journal.Record("I cried today!");
        journal.Record("I ate a delicious bug!");
        journal.Record("I was kissed by a frog!");
        Console.WriteLine(journal);

        journal.Remove(journal, new Random().Next(1, journal.DictionaryCount + 1));
        Console.WriteLine(journal);

        #endregion

        #region Persistence

        var fileName = "journal";
        StorageManager.SaveAsTextFile(journal, fileName);
        Console.WriteLine("Journal saved to text file.");

        StorageManager.LoadFromTextFile(fileName);
        Console.WriteLine("Journal loaded from text file.");

        #endregion
    }
}