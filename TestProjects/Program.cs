/*
    The following code takes a string, converts it a a charArray,
    to reverse and display the message.

    It then checks for the number of occurances of the letter 'o' and displays the count.
*/

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);
string newMessage = new String(message);
Console.WriteLine(newMessage);

int letterCount = 0;
foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}
Console.WriteLine($"'o' appears {letterCount} times.");