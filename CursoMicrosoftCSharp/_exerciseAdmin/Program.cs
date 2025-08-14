// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var permission = "Admin|Manager";
var level = 55;

var result1 = permission.Contains("Admin") && level > 55 ? "Welcome, Super Admin user." : "Welcome.";
Console.WriteLine($"User:  {result1}");

var result2 = permission.Contains("Admin") && level <= 55 ? "Welcome, Admin user." : "Welcome.";
Console.WriteLine($"User:  {result2}");

var result3 = permission.Contains("Manager") && level >= 20 ? "Contact an Admin for access." : "Welcome.";
Console.WriteLine($"User:  {result3}");

var result4 = permission.Contains("Manager") && level < 20 ? "You do not have sufficient privileges." : "Welcome.";
Console.WriteLine($"User:  {result3}");

var result5 = permission.Contains("User") && level < 20 ? "You do not have sufficient privileges." : "Welcome.";
Console.WriteLine($"User:  {result3}");