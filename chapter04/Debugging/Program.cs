using static System.Console;

static double Add(double a, double b)
{
    return a + b;
}

WriteLine($"Enter debug");

double a = 7.5;
double b = 3.2;
double answer = Add(a, b);
WriteLine($"{a} + {b} = {answer}");

WriteLine($"Press Enter to end the app");
ReadLine();