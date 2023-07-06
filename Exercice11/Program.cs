Console.WriteLine("--- Le nombre est-il divisible par...? ---\n");
Console.Write("Entrez un chiffre/nombre entier : ");
int number;
while(!int.TryParse(Console.ReadLine(), out number))
{
    Console.Write("Vous devez saisir un chiffre/nombre entier : ");
}
Console.Write("Entrez un chiffre/nombre entier comme diviseur : ");
int divider;
while (!int.TryParse(Console.ReadLine(), out divider))
{
    Console.Write("Vous devez saisir un chiffre/nombre entier : ");
}
if(number%divider == 0)
{
    Console.WriteLine($"Le {(number % 10 == number ? "chiffre" : "nombre")} {number} est divisible par {divider}");
} else
{
    Console.WriteLine($"Le {(number % 10 == number ? "chiffre" : "nombre")} {number} n'est pas divisible par {divider}");
}


