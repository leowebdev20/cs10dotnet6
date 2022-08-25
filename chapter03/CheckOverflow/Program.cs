using static System.Console;

try
{
    checked
    {
        int x = int.MaxValue - 1;
        WriteLine($"initial value: {x}");
        x++;
        WriteLine($"After 1: {x}");
        x++;
        WriteLine($"After 2: {x}");
        x++;
        WriteLine($"After 3: {x}");
    }
}
catch (OverflowException ex)
{
    WriteLine($"{ex.Message}!!!");
}

unchecked
{
    int y = int.MaxValue + 1;
}
