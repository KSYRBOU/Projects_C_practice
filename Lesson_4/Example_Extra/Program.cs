
Console.WriteLine("Enter the word!");
string text = Console.ReadLine();
int len = text.Length;
string result = String.Empty;

for (int i = 0; i < len; i++)
{
    for (int j = 1; j < len; j++)
    {
        char SymbolOne = text[i];
        char SymbolTwo = text[j];
        if (SymbolOne == SymbolTwo) result = "True";
        else result = "False";
    }
}
Console.WriteLine(result);
