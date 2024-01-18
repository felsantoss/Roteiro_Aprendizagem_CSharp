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