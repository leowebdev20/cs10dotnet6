using static System.Console;

namespace Packt.Shared;

public class Person
{
    //fields 
    public string? Name;
    public DateTime DateOfBirth;
    public List<Person> Children = new();

    //method
    public void WriteToConsole()
    {
        WriteLine($"{Name} was bon on a {DateOfBirth:dddd}");
    }

    //static method to multiply. A questo posso accedere con Person.ProcreateWith(p1, p2)
    public static Person Procreate(Person p1, Person p2)
    {
        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}"
        };

        p1.Children.Add(baby);
        p2.Children.Add(baby);

        return baby;
    }

    //instance method to multiply. A questo posso accedere con mary.ProcreateWith(p2)
    public Person ProcreateWith(Person partner)
    {
        return Procreate(this, partner);
    }
}
