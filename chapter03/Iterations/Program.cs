using static System.Console;
using static System.Convert;

// int x = 0;
// while (x < 10)
// {
//     WriteLine($"x = {x}");
//     x++;
// }

// string? password;
// do
// {
//     password = ReadLine();
//     x++;
//     WriteLine($"pass = {password}");

// } while (password != "Pa$$w0rd" && x < 10);

// if (x >= 10)
// {
//     WriteLine($"Too many tentatives");

// }
// else
// {
//     WriteLine($"Password is correct");
// }

// for (int y = 0; y <= 10; y++)
// {
//     WriteLine(y);
// }

// string[] names = new[] { "leo", "luca", "charlie" };
// foreach (string name in names)
// {
//     WriteLine($"{name} has {name.Length} length");
// }

int a = 10;
double b = a;
WriteLine(a);

double c = 3.4;
int d = (int)c;
WriteLine(d);

// long e = 10;
long e = 5_000_000_000;
int f = (int)e;
// WriteLine($"e is {e:N0} and f is {f:N0}");
// e = long.MaxValue;
// f = (int)e;
// WriteLine($"e is {e:N0} and f is {f:N0}");

double g = 9.8;
int h = ToInt32(g);
// WriteLine($"g is {g} and h is {h}");

// int number = 3;
// WriteLine(number.ToString());
// DateTime date = DateTime.Now;
// WriteLine(date.ToString());
// object me = new();
// WriteLine(me);

// byte[] binaryObject = new byte[128];
// (new Random()).NextBytes(binaryObject);
// WriteLine("binary obj as bytes:");
// for (int i = 0; i < binaryObject.Length; i++)
// {
//     Write($"{binaryObject[i]:X}");
// }
// WriteLine();
// string encoded = ToBase64String(binaryObject);
// WriteLine($"binary obj as base 64: {encoded}");

WriteLine($"how many eggs?");
string input = ReadLine();

if (int.TryParse(input, out int count))
{
    WriteLine($"there are {count}!");

}
else
{
    WriteLine($"not a number!");
}
