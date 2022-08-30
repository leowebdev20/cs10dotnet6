using Packt.Shared;
using static System.Console;

// the other fiels are instance members, this InterestRate is a static one!
BankAccount.InterestRate = 0.12M;
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Jones Heich";
jonesAccount.Balance = 3922423;
WriteLine("{0} earned {1:C}", jonesAccount.AccountName, jonesAccount.Balance * BankAccount.InterestRate);

// var bob = new Person();
Person bob = new();
bob.Name = "Bob Doe";
bob.DateOfBirth = new DateTime(1965, 10, 22);
bob.Children.Add(new Person() { Name = "Zoro" }); // C#3 or later
bob.Children.Add(new() { Name = "Sanji" }); // C#9 or later

WriteLine("{0} was born on {1:dddd, d MMMM yyyy}", bob.Name, bob.DateOfBirth);
WriteLine($"{bob.Name} has {bob.Children.Count} kids");
//While this is a constant field and a read-only field, which is preferable!!
WriteLine($"{bob.Name} species is {Person.Species} and was born in {bob.HomePlanet}");

for (int i = 0; i < bob.Children.Count; i++)
{
    WriteLine($"{i + 1} is {bob.Children[i].Name}");
}

// Different way to initialize the fields of a newly instantiated Person Type Object
Person alex = new()
{
    Name = "Alex Iyur",
    DateOfBirth = new DateTime(1995, 10, 02),
    FavoriteAncientWonder = WondersOfTheAncientWorld.ColossusOfRhodes,
    BucketList = WondersOfTheAncientWorld.GreatPyramidOfGiza | WondersOfTheAncientWorld.MausoleumAtHalicarnassus
};
// WriteLine(format: "{0} was born on {1:dd - MMM - yy} and he likes the {2}", arg0: alex.Name, arg1: alex.DateOfBirth, (int)alex.FavoriteAncientWonder);
WriteLine(format: "{0} was born on {1:dd - MMM - yy} and he wants to see {2}", arg0: alex.Name, arg1: alex.DateOfBirth, arg2: alex.BucketList);

// check the initial values of a new person
Person joe = new();
WriteLine(format: "{0} was born on {1:dd - MMM - yy} ", arg0: joe.Name, arg1: joe.Instantiated);
// using multiple constructors
Person mat = new(initialName: "Mat", homePlanet: "Mars");
WriteLine(format: "{0} was born on {1} ", arg0: mat.Name, arg1: mat.HomePlanet);

// callign the person methods!
bob.WriteToConsole();
WriteLine(bob.GetOrigin());
