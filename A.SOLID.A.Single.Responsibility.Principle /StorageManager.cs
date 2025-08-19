namespace A.SOLID.A.Single.Responsibility.Principle;

internal class StorageManager
{
    internal static void SaveAsTextFile(Journal journal, string fileName)
    {
        var filePath = $"{fileName}.txt";


        if (File.Exists(filePath))
        {
            // If the file exists and overwrite is true, overwrite the file
            File.AppendAllText(filePath, Environment.NewLine + journal.ToString());
        }
        else
        {
            // Otherwise, create a new file
            File.WriteAllText(filePath, journal.ToString());
        }
    }

    internal static void LoadFromTextFile(string fileName)
    {
        var filePath = $"{fileName}.txt";

        if (File.Exists(filePath))
        {
            var content = File.ReadAllText(filePath);
            Console.WriteLine($"Content of {fileName}:\n{content}");
        }
        else
        {
            Console.WriteLine($"File {fileName} does not exist.");
        }
    }
}