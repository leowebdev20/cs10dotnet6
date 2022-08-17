object height = 1.22;
object name = "Leo";
Console.WriteLine($"{name} is {height} meters tall");

// int lenght1 = name.Length;
int lenght2 = ((string)name).Length;
Console.WriteLine($"{name} has {lenght2} chars");

dynamic something = "Amed";

// something = 12;


// something = new[] { 3, 4, 6 };

Console.WriteLine($"Length is {something.Length}");