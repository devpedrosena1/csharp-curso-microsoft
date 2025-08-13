// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

/*
string[] fraudulentOrderIDs = new string[3]; // [0] [1] [2]

//atribuições
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
fraudulentOrderIDs[3] = "D000";
*/

string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];

// acessar
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

Console.WriteLine("\n======= FOREACH ======\n");

string[] names = ["Rowena", "Robin", "Bao"];
foreach (var name in names)
{
    Console.WriteLine(name);
}

int[] inventory = [ 200, 450, 700, 175, 250 ];

var sum = 0;
var bin = 0;

foreach (var items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"\nWe have {sum} items in inventory.");