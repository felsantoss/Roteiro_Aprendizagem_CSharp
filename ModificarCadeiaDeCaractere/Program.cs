/* string message = "What is the value <span>between the tags</span>";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;

Console.WriteLine(message.Substring(openingPosition, length)); */

string message = "(What if) I am (only interested) in the last (set of parentheses)?";
while (true) 
{
    int openingPosition = message.IndexOf('(');
    if
        (openingPosition == -1)
        break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;

    Console.WriteLine(message.Substring(openingPosition, length));

    message = message.Substring(closingPosition + 1);
}

Console.ReadKey();