// OUVERTURE
Console.WriteLine("=== Gestion des Contacts ===");
Console.Write("Merci de saisir le nombre de contacts : ");
int contactsAmount;
while(!int.TryParse(Console.ReadLine(), out contactsAmount) || contactsAmount <= 0)
{
    Console.Write("Merci de saisir un nombre entier positif : ");
}
string[] contacts = new string[contactsAmount];

while (true)
{
    // MENU PRINCIPAL
    Console.WriteLine("----- Ma liste de contacts -----");
    Console.WriteLine("1---- Saisir des contacts");
    Console.WriteLine("2---- Afficher mes contacts");
    Console.WriteLine("0---- Quitter\n");
    Console.Write("Faites votre choix : ");
    string input = Console.ReadLine();
    Console.Clear();

    // MENUS
    switch (input)
    {
        case "1": // MENU SAISIE
            if (contacts[contactsAmount - 1] is not null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Le tableau est déjà rempli!\n");
                Console.ResetColor();
                break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- Saisir les contacts -----");
            Console.ResetColor();
            for (int i = 0; i < contactsAmount; i++)
            {
                Console.Write($"Nom et prénom du contact N° {i + 1} : ");
                contacts[i] = Console.ReadLine();
            }
            Console.Clear();
            break;
        case "2": // MENU AFFICHAGE
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- Affichage des contacts -----");
            Console.ResetColor();
            for (int i = 0; i < contactsAmount; i++)
            {
                Console.WriteLine($"\t-Contact N° {i + 1} : {contacts[i]}");
            }
            Console.WriteLine("");
            break;
        case "0": // QUITTER
            Environment.Exit(0);
            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Saisie incorrecte!!\n");
            Console.ResetColor();
            break;
    }
}

