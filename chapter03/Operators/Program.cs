using static System.Console;

// int a = 3;
// int b = ++a;
// WriteLine($"a is {a} and b is {b}");
// int d = 3;
// int f = d++;
// WriteLine($"d is {d} and f is {f}");
// int g = 3;
// int h = 5;
// g += a;
// WriteLine($"g is {g} and h is {h}");



// bool x = true;
// bool z = false;

// static bool DoStuff()
// {
//     WriteLine("I am doing stuff");
//     return true;
// }

// WriteLine();
// WriteLine($"x & DoStuff() = {x & DoStuff()}");
// WriteLine($"z & DoStuff() = {z & DoStuff()}");
// WriteLine();
// WriteLine($"x && DoStuff() = {x && DoStuff()}");
// WriteLine($"z && DoStuff() = {z && DoStuff()}");


int a = 10;
int b = 6;

WriteLine($"a & b = {a & b}");

object o = 3;
int j = 4;

if (o is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine($"o is not an int so it cannot multiply");
}