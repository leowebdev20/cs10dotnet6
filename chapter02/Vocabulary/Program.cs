using System.Reflection;
System.Data.DataSet ds;
HttpClient client;

Assembly? assembly = Assembly.GetEntryAssembly();
if (assembly == null) return;

foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    Assembly a = Assembly.Load(name);

    int methodCount = 0;

    foreach (TypeInfo type in a.DefinedTypes)
    {
        methodCount += type.GetMethods().Count();
    }

    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount, arg2: name.Name
    );

}

char letter = 'A';
string bigLetter = "A";
string tab = @"Test\tTest";
string newLine = "Test\nTest";
double HEIght = 1.33;
Console.WriteLine(
    $"The variable {nameof(HEIght)} has the value {HEIght}."
);
Console.WriteLine(
    tab
);
Console.WriteLine(
    newLine
);