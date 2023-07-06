Console.WriteLine("--- Les suites chainées de nombres ---\n");
Console.Write("Merci de saisir un nombre : ");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.Write("Vous devez saisir un nombre entier : ");
}
int startingNumber = 1;
while(startingNumber <= number / 2)
{
    int total = 0;
    string display = $"{number} = ";
    int currentNumber = startingNumber;
    while(total < number) {
        total += currentNumber;
        display += $"{currentNumber}+";
        currentNumber++;
    }
    if(total == number) Console.WriteLine(display.Substring(0, display.Length -1));
    startingNumber++;
}