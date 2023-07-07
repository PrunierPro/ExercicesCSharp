Console.WriteLine("***** Tableaux des notes *****");
Console.Write("Combiens de notes comportera le tableau : ");
int notesAmount;
while (!int.TryParse(Console.ReadLine(), out notesAmount) || notesAmount <= 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Vous devez saisir un nombre entier positif : ");
    Console.ResetColor();
}

double[] notes = new double[notesAmount];
Console.WriteLine($"\nMerci de saisir les {notesAmount} notes :\n");
for(int i = 0; i < notesAmount; i++)
{
    Console.Write($"\t-Note {i + 1} : ");
    double note;
    while (!double.TryParse(Console.ReadLine(), out note) || note < 0 || note > 20)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\tVous devez saisir un nombre entre 1 et 20 : ");
        Console.ResetColor();
    }
    notes[i] = note;
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n--- Liste de notes ---");
Console.ResetColor();
for(int i = 0; i < notesAmount; i++)
{
    Console.WriteLine($"La note {i + 1} est de : {notes[i]}/20");
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n--- La note max est  : {notes.Max()}/20");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"--- La note min est  : {notes.Min()}/20");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"--- La moyenne est de  : {Math.Round(notes.Average(), 2)}/20");
