string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1; // ignorando o caractere de abertura 

int length = closingPosition - openingPosition;

Console.WriteLine(message.Substring(openingPosition, length));
Console.ReadKey();