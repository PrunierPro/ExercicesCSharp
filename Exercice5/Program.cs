Console.Write("Veuillez saisir un nombre : ");
double premierNombre;
while(!double.TryParse(Console.ReadLine(), out premierNombre))
{
    Console.Write("Vous devez saisir un nombre : ");
}
double deuxiemeNombre;
Console.Write("Veuillez saisir un nombre : ");
while(!double.TryParse(Console.ReadLine(), out deuxiemeNombre))
{
    Console.Write("Vous devez saisir un nombre : ");
}
double resultat = premierNombre + deuxiemeNombre;
Console.WriteLine($"La somme des deux nombres est : {resultat}");