Console.WriteLine("--- Quel sera le montant de mes impôts ? ---\n");
Console.Write("Entrez le montant net imposable du foyer (en Euros) : ");
double money;
while (!double.TryParse(Console.ReadLine(), out money) || money < 0)
{
    Console.Write("Vous devew entrer un nombre positif : ");
}
Console.Write("Entrez le nombre d'adulte du foyer : ");
int adults;
while (!int.TryParse(Console.ReadLine(), out adults) || adults < 0)
{
    Console.Write("Vous devez entrer un nombre entier positif : ");
}
Console.Write("Entrez le nombre d'enfants du foyer : ");
int children;
while (!int.TryParse(Console.ReadLine(), out children) || children < 0)
{
    Console.Write("Vous devez entrer un nombre entier positif : ");
}
double nbPart = adults + (children >= 3 ? 0.5 * 2 + children - 2 : 0.5 * children);
double part = money / nbPart;
if (part > 157806)
{
    part = (part - 157806) * 0.45 + (157806 - 73369) * 0.41 + (73369 - 25659) * 0.30 + (25659 - 10064) * 0.11;
}
else if (part > 77369)
{
    part = (part - 73369) * 0.41 + (73369 - 25659) * 0.30 + (25659 - 10064) * 0.11;
}
else if (part > 25659)
{
    part = (part - 25659) * 0.30 + (25659 - 10064) * 0.11;
}
else if (part > 10064)
{
    part = (part - 10064) * 0.11;
}
else
{
    part = 0;
}
double taxes = Math.Round(part * nbPart);
Console.WriteLine($"\nVous allez payer {taxes} Euros");