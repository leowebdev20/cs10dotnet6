using static System.Console;
WriteLine($"There are {args.Length} arguments");
foreach (string arg in args)
{
    WriteLine($"Arg: {arg}");
}
if (args.Length < 3)
{
    WriteLine("Have at least 3 args!");
    WriteLine("dotnet run red yellow 50");
    return;
}
ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0],
    ignoreCase: true
);
BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1],
    ignoreCase: true
);
try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("Not supported");
}
if (OperatingSystem.IsWindows())
{
    WriteLine("It's supported");
}
#if NET6_0_OR_GREATER
WriteLine("It's supported!!!");
#else
WriteLine("It's not supported!!!");
#endif