using static System.Console;

WriteLine("before parsing");
Write("whats your age? ");
string? input = ReadLine();

try
{
    int age = int.Parse(input);
    WriteLine($"age is {age}!");
}
catch (OverflowException)
{
    WriteLine($"number too big or to small");
}
catch (FormatException) when (input.Contains("."))
{
    WriteLine($"cannot use float point");
}
catch (FormatException)
{
    WriteLine($"the age is not a valid number");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
    // throw;
}

WriteLine("after parsing");
