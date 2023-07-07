string[] namesTab = { "Sebastian", "Allan", "Dominique", "Christopher", "Eric" };
List<string> names = namesTab.ToList<string>();
int remaining = names.Count();
List<string> winners = new List<string>();
Random rand = new Random();

while (true)
{
    Console.WriteLine("--- Le grand tirage au sort ---\n");
    Console.WriteLine(" 1---Effectuer un tirage");
    Console.WriteLine(" 2---Voir la liste des personnes déjà tirées");
    Console.WriteLine(" 3---Voir la liste des personnes restantes");
    Console.WriteLine(" 0---Quitter\n");
    Console.Write("Faites votre choix : ");
    string input = Console.ReadLine();
    Console.Clear();

    switch (input)
    {
        case "1":
            if(names.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Tout le monde à été tiré! Remise à zéro...");
                names = namesTab.ToList<string>();
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            int winner = rand.Next(0, names.Count());
            Console.WriteLine("***************************************");
            Console.WriteLine($"* L'heureux gagnant est : {names[winner]}*");
            Console.WriteLine("***************************************");
            winners.Add(names[winner]);
            names.RemoveAt(winner);
            Console.ResetColor();
            break;
        case "2":
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*************************************");
            Console.WriteLine("* Liste des personnes déjà tirées : *");
            Console.WriteLine("*************************************");
            Console.ResetColor();
            showAll(winners);
            break;
        case "3":
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*******************************************");
            Console.WriteLine("* Liste des personnes pas encore tirées : *");
            Console.WriteLine("*******************************************");
            Console.ResetColor();
            showAll(names);
            break;
        case "0":
            Environment.Exit(0);
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Saisie incorrecte!\n");
            Console.ResetColor();
            break;
    }

}

void showAll(List<string> names)
{
    string offset = default;
    foreach(string name in names)
    {
        Console.WriteLine(offset + name);
        offset += " ";
    }
}


