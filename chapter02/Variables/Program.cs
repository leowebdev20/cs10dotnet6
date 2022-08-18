using System.Xml;

object height = 1.22;
object name = "Leo";
Console.WriteLine($"{name} is {height} meters tall");

// int lenght1 = name.Length;
int lenght2 = ((string)name).Length;
Console.WriteLine($"{name} has {lenght2} chars");

dynamic something = "Amed";

// something = 12;

var decim = 100.00M;
var ulon = 100UL;

// something = new[] { 3, 4, 6 };

Console.WriteLine($"Length is {something.Length}");

var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

XmlDocument xml3 = new();


// var file1 = File.CreateText("something.txt");
// StreamWriter file2 = File.CreateText("something.txt");

int number = default;

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(string) = {default(string)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");

Console.WriteLine($"default(DateTime) = {number}");

// Arrays
string[] names;

names = new string[4];

string[] newNames = new[] { "Leo", "Marta", "Gianni", "Paolo" };


names[0] = "Leo";
names[1] = "Marta";
names[2] = "Gianni";
names[3] = "Paolo";

for (int i = 0; i < names.Length; i++)
{
    // Console.WriteLine(names[i]);
    Console.Write(names[i]);

}