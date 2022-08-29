using static System.Console;

namespace Packt;

public class Calculator
{
    public static void Gamma()
    {
        WriteLine("In gamma");
        Delta();
    }

    private static void Delta()
    {
        WriteLine("In Delta");
        File.OpenText("bad path");
    }
}