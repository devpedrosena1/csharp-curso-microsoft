// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

var saleAmout = 1001;
var discount = saleAmout > 1000 ? 100 : 50;
Console.WriteLine($"Discount is {discount}");