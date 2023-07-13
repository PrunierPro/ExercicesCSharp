Console.WriteLine("--- Opérations mathématiques ---");
Console.Write("Entrez un premier nombre: ");
double num1 = controleSaisieDouble();
Console.Write("Entrez un second nombre: ");
double num2 = controleSaisieDouble();

(double somme, double diff, double quotient, double produit) resultat = Operation(num1, num2);
Console.WriteLine($"{num1} + {num2} = {resultat.somme}\n{num1} - {num2} = {resultat.diff}\n{num1} / {num2} = {resultat.quotient}\n{num1} x {num2} = {resultat.produit}");


(double somme, double diff, double quotient, double produit) Operation(double num1, double num2)
{
    return (num1+num2, num1-num2, num1/num2, num1*num2);
}

double controleSaisieDouble()
{
    double res;
    while(!double.TryParse(Console.ReadLine(), out res))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Vous devez entrer un nombre : ");
        Console.ResetColor();
    }
    return res;
}