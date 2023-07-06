Console.WriteLine("--- Trouver le nombre mystère ---\n");
int mystery = new Random().Next(1, 51);
int number = 0;
int attempts = 0;
while(number != mystery)
{
    Console.Write("\tVeuillez saisir un nombre entre 1 et 50 inclus : ");
    if(!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 50)
    {
        Console.WriteLine("\t\tMauvaise saisie. Vous devez saisir un nombre entier entre 1 et 50 inclus.");
        continue;
    }
    attempts++;
    Console.ForegroundColor = ConsoleColor.Red;
    if (number > mystery)
    {
        Console.WriteLine("\t\tLe nombre mystère est plus petit.");
    } else if(number < mystery)
    {
        Console.WriteLine("\t\tLe nombre mystère est plus grand.");
    }
    Console.ResetColor();
}
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nBravo !!!! Vous avez trouvé le nombre mystère !\n\nVous avez trouvé en {attempts} coup{(attempts > 1 ? "s" : "")}.");
