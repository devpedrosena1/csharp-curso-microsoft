// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// criar a matriz
string[] fraudulentIds = [ "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" ];

foreach (var ids in fraudulentIds)
{
    if (ids.StartsWith("B"))
    {
        Console.WriteLine(ids);
    }
}