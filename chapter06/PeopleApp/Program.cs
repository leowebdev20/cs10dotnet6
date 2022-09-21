
using Packt.Shared;

using static System.Console;

Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };

//call instance method
Person baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";

//call static method
Person baby2 = Person.Procreate(harry, jill);

WriteLine($"{harry.Name} has {harry.Children.Count}");
WriteLine($"{harry.Name} first child is named {harry.Children[0].Name}");
WriteLine($"{jill.Name} first child is the {jill.Children[0].Name}");

string s1 = "Hello ";
string s2 = "World!";
WriteLine(string.Concat(s1, s2));
WriteLine(s1 + s2);

//call an operator
WriteLine((harry * jill).Name);

WriteLine($"5! is {Person.Factorial(5)}");

static void Harry_Shout(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person p = (Person)sender;
    WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
}
harry.Shout = Harry_Shout;
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();