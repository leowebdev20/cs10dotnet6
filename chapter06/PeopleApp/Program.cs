
using Packt.Shared;

using static System.Console;

Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };

//call instance method
Person baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";

Person baby2 = Person.Procreate(harry, jill);

WriteLine($"{harry.Name} has {harry.Children.Count}");
WriteLine($"{harry.Name} first child is named {harry.Children[0].Name}");
WriteLine($"{jill.Name} first child is the {jill.Children[0].Name}");

string s1 = "Hello ";
string s2 = "World!";
WriteLine(string.Concat(s1, s2));
WriteLine(s1 + s2);