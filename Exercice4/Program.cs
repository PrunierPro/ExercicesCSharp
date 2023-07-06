Console.Write("Veuillez saisir votre nom: ");
string lastName = Console.ReadLine();
Console.Write("Veuillez saisir votre prénom: ");
string firstName = Console.ReadLine();
Console.Write("Veuillez saisir votre âge: ");
int age;
while(!int.TryParse(Console.ReadLine(), out age))
{
    Console.Write("Vous devez saisir un nombre entier : ");
}
Console.WriteLine($"Bonjour {firstName} {lastName}, vous avez {age} ans");
