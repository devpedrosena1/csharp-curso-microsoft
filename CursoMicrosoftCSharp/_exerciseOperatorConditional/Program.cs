// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var coin = new Random();
var flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "Heads" : "Tails");