Console.WriteLine("--- Gestion des notes ---\n");
Console.WriteLine("Veuillez saisir 5 notes :\n");
double maxNote = 0;
double minNote = 20;
double total = 0;
for(int i = 0; i < 5; i++)
{
    Console.Write($"\t- Merci de saisir la note {i} (sur 20) : ");
    double note;
    while(!double.TryParse(Console.ReadLine(), out note) || note > 20 || note < 0)
    {
        Console.Write("\tVous devez entrer un note positive sur 20 : ");
    }
    if (note > maxNote) maxNote = note;
    if (note < minNote) minNote = note;
    total += note;
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nLa meilleure note est {maxNote}/20");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La pire note est {minNote}/20");
Console.ResetColor();
Console.WriteLine($"La moyenne des notes est {total/5}/20");
