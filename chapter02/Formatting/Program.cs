using static System.Console;

int numberOfApples = 12;
decimal priceOfApples = 0.35M;

WriteLine(format: "{0} apples cost {1:C}", arg0: numberOfApples, arg1: priceOfApples * numberOfApples);

string formatted = string.Format(format: "{0} apples cost {1:C}", numberOfApples, priceOfApples * numberOfApples);

// WriteToFile(formatted);

WriteLine(formatted);

WriteLine($"{numberOfApples} apples cost {numberOfApples * priceOfApples:C}");

var name = "leo";
var surname = "rossi";
var fullName = $"{name} {surname}";

WriteLine(fullName);


string applesText = "apples";
int applesCount = 14342;

WriteLine(format: "{0, -10} {1,6:N0}", arg0: applesText, arg1: applesCount);


// Write("Type your first name and press ENTER:  ");
// string? firstName = ReadLine();

// Write("Type your age and press ENTER:  ");
// string? age = ReadLine();

// WriteLine($"Hello {firstName}, you look good for {age}");

Write("Press any key:  ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}", key.Key, key.KeyChar, key.Modifiers);



