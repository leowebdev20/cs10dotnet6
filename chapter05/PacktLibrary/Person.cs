using System; // DateTime
using static System.Console;
using System.Collections.Generic; // List<T>

namespace Packt.Shared
{
    // public class Person : System.Object
    public partial class Person : object
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        // public List<Person> Children = ();On NET.6, but the Class Library is NET2 so it doesn't work with c#7 compiler!
        public List<Person> Children = new List<Person>();
        //constants
        public const string Species = "Human";
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        //let's set two og these fiels in a constructors!
        public Person()
        {
            //set default values for fields
            //including read-only fields
            Name = "Not Set";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        //METHODS

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}!");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}!";
        }

        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }
        public (string Name, int Number) GetNamedFruit()
        {
            return ("Apples", 5);
        }
        // deconstructors
        public void Deconstruct(out string name, out DateTime dob)
        {
            name = Name;
            dob = DateOfBirth;
        }

        public string SayHello()
        {
            return $"{Name} says Hello";
        }
        public string SayHelloTo(string name)
        {
            return $"{Name} says Hello to {name}!";
        }

        public void PassingParameters(int x, ref int y, out int z)
        {
            z = 99;
            x++;
            y++;
            z++;
        }

    }
}