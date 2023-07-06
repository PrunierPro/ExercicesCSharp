Console.WriteLine("--- Quel sera le montant de l'indemnité de licenciement ? ---\n");
Console.Write("Veuillez saisir le dernier salaire (en Euros) : ");
int salary;
while(!int.TryParse(Console.ReadLine(), out salary) || salary <= 0)
{
    Console.Write("Vous devez saisir un nombre entier positif non-nul : ");
}
Console.Write("Veuillez saisir votre âge : ");
int age;
while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
{
    Console.Write("Vous devez saisir un nombre entier positif non-nul : ");
}
Console.Write("Veuillez saisir le nombre d'années d'ancienneté : ");
int seniority;
while (!int.TryParse(Console.ReadLine(), out seniority) || seniority < 0)
{
    Console.Write("Vous devez saisir un nombre entier positif : ");
}
int prime = default;
if(seniority <= 10)
{
    prime = salary / 2 * seniority; 
} else
{
    prime = salary * seniority;
}
if (age > 45)
{
    if(age >= 50)
    {
        prime += salary * 5;
    } else
    {
        prime += salary * 2;
    }
}
Console.WriteLine($"Votre indemnité est de : {prime} Euros");
