using static System.Console;

TimesTable(number: 12);

decimal taxToPay = CalculateTax(amout: 900.23M, "US");
WriteLine($"The TOTAL VAT IS {taxToPay:C}");

int cardinal = 12;
WriteLine($"Ordinal of {cardinal} is {CardinalToOrdinal(cardinal)}");

static void TimesTable(byte number)
{
    WriteLine($"this is the {number} times table:");
    for (int row = 0; row <= 12; row++)
    {
        WriteLine($"{row} x {number} = {row * number}");
    }
}


static decimal CalculateTax(decimal amout, string twoLetterCountry)
{
    decimal rate = 0.0M;
    switch (twoLetterCountry)
    {
        case "CH":
            rate = 0.8M;
            break;
        case "IT":
            rate = 5.90M;
            break;
        case "US":
            rate = 4;
            break;
        default:
            rate = 2.0M;
            break;
    }
    return amout * rate;
}

/// <summary>
/// Pass a 32-biut integer and will be converted in its ordinal
/// </summary>
/// <param name="number">Number  is a cardinal value like 3!</param>
/// <returns">Number as an ordinal value like 3rd!</returns>
static string CardinalToOrdinal(int number)
{
    switch (number)
    {
        case 11:
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit = number % 10;
            string suffix = lastDigit switch
            {
                1 => "st",
                2 => "ns",
                3 => "rd",
                _ => "th",
            };
            return $"{number + suffix}";
    }
}