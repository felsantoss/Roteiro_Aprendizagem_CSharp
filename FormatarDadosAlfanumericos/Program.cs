string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

// Formatação de moeda
decimal price = 123.45m;
int discount = 50;

Console.WriteLine($"\nPrice: {price:C} (Save: {discount:C})");