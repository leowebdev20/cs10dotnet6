int numberOfApples = 12;
decimal priceOfApples = 0.35M;

Console.WriteLine(format: "{0} apples cost {1:C}", arg0: numberOfApples, arg1: priceOfApples * numberOfApples);

string formatted = string.Format(format: "{0} apples cost {1:C}", numberOfApples, priceOfApples * numberOfApples);

// WriteToFile(formatted);

Console.WriteLine(formatted);

Console.WriteLine($"{numberOfApples} apples cost {numberOfApples * priceOfApples:C}");

var name = "leo";
var surname = "rossi";
var fullName = $"{name} {surname}";

Console.WriteLine(fullName);


string applesText = "apples";
int applesCount = 14342;

Console.WriteLine(format: "{0, -10} {1,6:N0}", arg0: applesText, arg1: applesCount);
