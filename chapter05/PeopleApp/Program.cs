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

// using tuples
(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, there are {fruit.Item2}");
var namedFruit = bob.GetNamedFruit();
WriteLine($"{namedFruit.Name}, there are {namedFruit.Number}");

// Inferring tuple names
var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} fruits.");
var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} fruits.");
(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"{fruitName} are {fruitNumber}.");

var (name1, dob1) = bob;
WriteLine($"Deconstructed: {name1}, {dob1}");

WriteLine(bob.SayHello());
WriteLine(bob.SayHelloTo("Leo"));

int a = 10;
int b = 20;
// int c = 30;
WriteLine($"Before: a = {a}, b = {b}");
bob.PassingParameters(a, ref b, out int c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");

Person sam = new()
{
    Name = "Sam",
    DateOfBirth = new(1973, 12, 03)
};
WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);
sam.FavoriteIceCream = "stracciatella";
sam.FavoritePrimaryColor = "blue";
WriteLine(sam.FavoriteIceCream);
WriteLine(sam.FavoritePrimaryColor);

// Exploring pattern matching
object[] passengers = {
        new FirstClassPassenger { AirMiles = 1_419 },
        new FirstClassPassenger { AirMiles = 16_562 },
        new BusinessClassPassenger(),
        new CoachClassPassenger { CarryOnKG = 25.7 },
        new CoachClassPassenger { CarryOnKG = 0 },
      };

foreach (object passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        /* C# 8 syntax
        FirstClassPassenger p when p.AirMiles > 35000 => 1500M,
        FirstClassPassenger p when p.AirMiles > 15000 => 1750M,
        FirstClassPassenger                           => 2000M, */
        // C# 9 syntax
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35000 => 1500M,
            > 15000 => 1750M,
            _ => 2000M
        },
        BusinessClassPassenger => 1000M,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
        CoachClassPassenger => 650M,
        _ => 800M
    };
    WriteLine($"Flight costs {flightCost:C} for {passenger}");
}

// Working with records
ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "Winger"
};
// the following is not allowed with init properties
// jeff.FirstName = "Geoff";

ImmutableVehicle car = new()
{
    Brand = "Mazda MX-5",
    Color = "Metallic Soul Red",
    Wheels = 4
};
ImmutableVehicle repaintedCar = car
  with
{ Color = "Polymetallic Grey" };
WriteLine($"Original car color was {car.Color}.");
WriteLine($"New car color is {repaintedCar.Color}.");
ImmutableAnimal oscar = new("Oscar", "Labrador");
var (who, what) = oscar; // calls Deconstruct method
WriteLine($"{who} is a {what}.");