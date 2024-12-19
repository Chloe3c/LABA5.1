Random random = new Random();
char[] characters = new char[11];

for (int i = 0; i < characters.Length; i++)
{
    characters[i] = (char)random.Next('A', 'z' + 1);
}

string randomString = new string(characters);
Console.WriteLine($"Случайная строка: {randomString}");

string cleanedString = randomString.Replace("  ", " ").Trim();
Console.WriteLine($"Строка без лишни
