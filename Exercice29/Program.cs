Console.WriteLine("--- Gestion des notes ---\n");
Console.WriteLine("Veuillez saisir les notes :\n(999 pour calculer)");
double maxNote = 0;
double minNote = 20;
double total = 0;
int amount = 1;
double note = default;
while(note != 999)
{
    Console.Write($"\t- Merci de saisir la note {amount} (sur 20) : ");
    if(!double.TryParse(Console.ReadLine(), out note) || note < 0 || note > 20)
    {
        if (note == 999) break;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\t\tMauvaise saisie, la note doit être un nombre entier sur 20.");
        Console.ResetColor();
        continue;
    }
    maxNote = note > maxNote ? note : maxNote;
    minNote = note < minNote ? note : minNote;
    total += note;
    amount++;
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nLa meilleure note est {maxNote}/20");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"La pire note est {minNote}/20");
Console.ResetColor();
Console.WriteLine($"La moyenne des notes est {total / amount}/20");
