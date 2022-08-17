uint naturalNumber = 23;

int integerNumber = -23;

int integerNumber2 = 100_000_000;

float realNumber = 234.2F;

double anotherRealNumber = 232432.3;

Console.WriteLine($"int uses {sizeof(int)} bytes and can store numebrs is the range {int.MinValue:N0} to {int.MaxValue:N0}");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numebrs is the range {double.MinValue:N0} to {double.MaxValue:N0}");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numebrs is the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

Console.WriteLine("using dobules:");
double a = 0.1;
double b = 0.2;

if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does not equals {0.3}");

}
