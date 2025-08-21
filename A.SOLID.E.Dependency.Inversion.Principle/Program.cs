using A.SOLID.E.Dependency.Inversion.Principle.Notifiers;
using A.SOLID.E.Dependency.Inversion.Principle.Services;

namespace A.SOLID.E.Dependency.Inversion.Principle;

using Bogus;

class Program
{
    static void Main(string[] args)
    {
        #region Initialisation

        var random = new Random();

        var faker = new Faker();
        var names = new List<string>();
        var amount = random.Next(5, 11);
        for (int i = 0; i < amount; i++)
        {
            var firstName = faker.Name.FirstName();
            // Console.WriteLine($"The name {i + 1} is {firstName}");
            names.Add(firstName);
        }

        var index = random.Next(0, names.Count);
        var name = names[index];
        Console.WriteLine($"The names contains {names.Count} names.");
        Console.WriteLine($"The selected name is {name.ToUpper()}");

        #endregion

        #region DIP

        var email = new Email();
        var sms = new Sms();

        var bookViaEmail = new Book(email);
        bookViaEmail.Confirm(name);

        var bookViaSms = new Book(sms);
        bookViaSms.Confirm(name);

        #endregion
    }
}