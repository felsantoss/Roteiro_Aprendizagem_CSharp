/*
// interpolação de caracteres
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

// Formatação de moeda
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"\nPrice: {price:C} (Save: {discount:C})");

// Formatação de números
decimal measurement = 123456.78912m;
Console.WriteLine($"\nMeasurement: {measurement:N} units");

// Formatação de percentual 
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");

// Combinando formatação
decimal priceReal = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (priceReal - salePrice), priceReal);

Console.WriteLine(yourDiscount); */

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"Shares: {productShares:N3} Product");
Console.WriteLine($"Sub total: {subtotal:C}");
Console.WriteLine($"Tax: {taxPercentage:P2}");
Console.WriteLine($"Total billed: {total:C}");

string input = "Pad this";
Console.WriteLine(input.PadLeft(12));

Console.ReadKey();