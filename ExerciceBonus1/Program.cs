Console.Write("Veuillez entrer un nombre entier supérieur à 0 : ");
int n;
while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
{
    Console.Write("Vous devez entrer un nombre entier supérieur à 0 : ");
}
Console.Clear();
Console.WriteLine("\tTables de multiplications:");
Console.WriteLine(@"=========================================
| 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |10 |
=========================================");
for(int i = 1; i <= n; i++)
{
    for(int j = 1; j <= 10; j++)
    {
        int multi = j * i;
        Console.Write($"|{multi, -3}");
    }
    Console.WriteLine("|");
    for(int j = 0; j < 10; j++)
    {
        Console.Write("+---");
    }
    Console.WriteLine("+");
}
