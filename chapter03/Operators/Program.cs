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

// string path = "/Users/seren/Documents/lavori/asptutorial/Code/chapter03";
// string path = @"C:\Code/chapter03";
string path = "/Users/seren/Documents/lavori/asptutorial/Code/chapter03";

WriteLine($"Press R for read-only or W for writeable");
ConsoleKeyInfo key = ReadKey();
WriteLine();

Stream? s;

if (key.Key == ConsoleKey.R)
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Read);
}
else
{
    s = File.Open(
        Path.Combine(path, "file.txt"),
        FileMode.OpenOrCreate,
        FileAccess.Write);
}

string message;

// switch (s)
// {
//     case FileStream writableFile when s.CanWrite:
//         message = "The stream is a file what I can write to";
//         break;
//     case FileStream readOnlyFile:
//         message = "The stream is a read only file";
//         break;
//     case MemoryStream ms:
//         message = "The stream is a memory address";
//         break;
//     default:
//         message = "The stream is another type";
//         break;
//     case null:
//         message = "The stream is null";
//         break;
// }

message = s switch
{
    FileStream writableFile when s.CanWrite
            => "The stream is a file what I can write to",
    FileStream readOnlyFile
       => "The stream is a read only file",
    MemoryStream ms
       => "The stream is a memory address",
    null
       => "The stream is null",
    _
       => "The stream is another type",
};

WriteLine(message);
