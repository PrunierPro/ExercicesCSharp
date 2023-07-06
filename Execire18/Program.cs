Console.WriteLine("--- Dans quelle catégorie mon enfant est-il ? ---\n");
Console.Write("Entrez l'âge de l'enfant : ");
int age;
while (!int.TryParse(Console.ReadLine(), out age))
{
    Console.Write("Vous devez entrer un nombre entier : ");
}
string categorie = "Baby";
switch (age)
{
    case > 18:
        Console.WriteLine("Ce n'est pas un enfant !");
        return;
    case > 12:
        categorie = "Cadet";
        break;
    case > 10:
        categorie = "Minime";
        break;
    case > 8:
        categorie = "Pupille";
        break;
    case > 6:
        categorie = "Poussin";
        break;
    case > 3:
        categorie = "Baby";
        break;
    default:
        Console.WriteLine("Votre enfant est trop jeune !");
        return;
}
Console.WriteLine($"Votre enfant est dans la catégorie \"{categorie}\" !");
