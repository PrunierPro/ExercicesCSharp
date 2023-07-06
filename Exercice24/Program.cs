Console.WriteLine("--- Les suites chainées de nombres ---\n");
Console.Write("Merci de saisir un nombre : ");
int number;
while(!int.TryParse(Console.ReadLine(), out number))
{
    Console.Write("Vous devez saisir un nombre entier : ");
}
for(int i = 0; i <= number/2; i++)
{
    int total = 0;
    string display = $"{number} = ";
    for(int j = i; total < number; j++)
    {
        total += j;
        display += $"{j}+";
    }
    if(total == number)
    {
        Console.WriteLine(display.Substring(0, display.Length-1));
    }
}
