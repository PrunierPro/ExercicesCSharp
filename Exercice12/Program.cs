Console.WriteLine("--- Dans quelle catégorie mon enfant est-il ? ---\n");
Console.Write("Entrez l'âge de l'enfant : ");
int age;
while(!int.TryParse(Console.ReadLine(), out age))
{
    Console.Write("Vous devez entrer un nombre entier : ");
}
string categorie = "Baby";
if(age > 18)
{
    Console.WriteLine("Ce n'est plus un enfant!");
    return;
} else if(age > 12)
{
    categorie = "Cadet";
} else if(age > 10)
{
    categorie = "Minime";
} else if(age > 8)
{
    categorie = "Pupille";
} else if(age > 6)
{
    categorie = "Poussin";
} else if(age < 3)
{
    Console.WriteLine("L'enfant est trop jeune!");
    return;
}
Console.WriteLine($"Votre enfant est dans la catégorie \"{categorie}\" !");
