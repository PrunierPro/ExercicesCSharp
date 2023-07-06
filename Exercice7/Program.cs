Console.WriteLine("--- Calcul de la longeur de l'hypothénuse ---");
Console.Write("Entrez la longeur du premier côté (en cm) : ");
double firstLength;
while (!double.TryParse(Console.ReadLine(), out firstLength))
{
    Console.Write("Vous devez entrer un nombre : ");
}
Console.Write("Entrez la longeur du deuxième côté (en cm) : ");
double secondLength;
while (!double.TryParse(Console.ReadLine(), out secondLength))
{
    Console.Write("Vous devez entrer un nombre : ");
}
Console.WriteLine($"La longueur de l'hypopthénuse est : {Math.Round(Math.Sqrt(Math.Pow(firstLength, 2) + Math.Pow(secondLength, 2)), 2)} cm");
