int input = -1;
double maxNote = 0;
double minNote = 20;
double total = 0;
int amount = 1;
do
{
    Console.Clear();
    switch (input)
    {
        case 1:
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"--- Saisir les notes ---
(999 pour stopper la saisie)
");
            Console.ResetColor();
            double note = default;
            do
            {
                Console.Write($"Merci de saisir la note {amount} (sur 20) : ");
                if (!double.TryParse(Console.ReadLine(), out note) || note < 0 || note > 20)
                {
                    if (note == 999) break;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tMauvaise saisie, la note doit être un nombre entier sur 20.");
                    Console.ResetColor();
                    continue;
                }
                maxNote = note > maxNote ? note : maxNote;
                minNote = note < minNote ? note : minNote;
                total += note;
                amount++;
            } while (note != 999);
            Console.Clear();
            break;
        case 2:
            if(amount <= 1)
            {
                Console.WriteLine("Vous devez saisir au moins une notre avant d'utiliser cette fonction.");
                break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($@"--- La plus grande note ---

La note la plus grande est :  {maxNote}/20
");
            Console.ResetColor();
            break;
        case 3:
            if (amount <= 1)
            {
                Console.WriteLine("Vous devez saisir au moins une notre avant d'utiliser cette fonction.");
                break;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($@"--- La plus petite note ---

La note la plus petite est :  {minNote}/20
");
            Console.ResetColor();
            break;
        case 4:
            if (amount <= 1)
            {
                Console.WriteLine("Vous devez saisir au moins une notre avant d'utiliser cette fonction.");
                break;
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($@"--- La moyenne des notes ---

La moyenne des notes est :  {Math.Round(total/(amount-1),2)}/20
");
            Console.ResetColor();
            break;
        case 0:
            Environment.Exit(0);
            break;
    }
    Console.WriteLine(@"--- Gestion des notes avec menu ---

1----Saisir les notes
2----La plus grande note
3----La plus petite note
4----La moyenne des notes
0----Quitter
");
    Console.Write("Faites votre choix : ");
    if (!int.TryParse(Console.ReadLine(), out input))
    {
        input = -1;
        continue;
    }
} while (input != 0);