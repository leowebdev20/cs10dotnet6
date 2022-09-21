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

    //operator to multiply
    public static Person operator *(Person p1, Person p2)
    {
        return Person.Procreate(p1, p2);
    }

    //method with a local Function
    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException($"{nameof(number)} cannot be less than zero");
        }
        return localFactorial(number);

        int localFactorial(int localNumber) //local function
        {
            if (localNumber < 1) return 1;
            return localNumber * localFactorial(localNumber - 1);
        }
    }

    //delegate field 
    public EventHandler? Shout;

    //data field
    public int AngerLevel;

    //method
    public void Poke()
    {
        AngerLevel++;
        if (AngerLevel >= 3)
        {
            if (Shout != null)
            {
                Shout(this, EventArgs.Empty);
                //or you can use Shout?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
