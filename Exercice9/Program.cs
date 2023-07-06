Console.WriteLine("--- Calcul des intérêts ---\n");
Console.Write("Entrez Capital de départ (en Euro) : ");
double capital;
while (!double.TryParse(Console.ReadLine(), out capital))
{
    Console.Write("Vous devez entrer un nombre : ");
}
Console.Write("Entrez le taux d'intêret (en %) : ");
double rate;
while (!double.TryParse(Console.ReadLine(), out rate))
{
    Console.Write("Vous devez entrer un nombre : ");
}
rate /= 100;
Console.Write("Entrez la durée de l'épargne (en années) : ");
int years;
while (!int.TryParse(Console.ReadLine(), out years))
{
    Console.Write("Vous devez entrer un nombre entier : ");
}
double finalCapital = capital * Math.Pow(1 + rate, years);
Console.WriteLine($"Le montant des intérêts sera de {Math.Round(finalCapital - capital, 2)} Euros après {years} ans");
Console.WriteLine($"Le capital final sera de {Math.Round(finalCapital, 2)} Euros");