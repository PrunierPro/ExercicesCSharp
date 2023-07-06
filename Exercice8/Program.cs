Console.Write("Entrez le prix HT de l'objet (en Euro) : ");
double price;
while(!double.TryParse(Console.ReadLine(), out price))
{
    Console.Write("Vous devez entrer un nombre : ");
}
Console.Write("Entrez le taux de TVA (en %) : ");
double tva;
while (!double.TryParse(Console.ReadLine(), out tva))
{
    Console.Write("Vous devez entrer un nombre : ");
}
double montantTva = price / 100 * tva;
Console.WriteLine($"Le montant de la T.V.A est de {Math.Round(montantTva, 2)} Euros");
Console.WriteLine($"Le prix TTC de l'objet est de {Math.Round(price + montantTva, 2)} Euros");
