using System.Text.RegularExpressions;

bool VerificationADN(string chaine)
{
    return !Regex.IsMatch(chaine, "[^actg]");
}

string SaisieADN(string message)
{
    Console.Write(message);
    string chaine = Console.ReadLine().ToLower().Trim();
    while (!VerificationADN(chaine))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Saisie incorrecte ! Réessayez : ");
        Console.ResetColor();
        chaine = Console.ReadLine().ToLower().Trim();
    }
    return chaine;
}

double Proportion(string chaine, string sequence)
{
    int matchCount = Regex.Matches(chaine, sequence).Count;
    return Math.Round(((double) matchCount * sequence.Length / chaine.Length) * 100, 2);
}

Console.WriteLine("--- ADN ---");
string chaine = SaisieADN("Veuillez saisir une chaine adn : ");
string sequence = SaisieADN("Veuillez saisir une sequence adn : ");
Console.WriteLine($"La chaine {chaine} contient {Proportion(chaine, sequence)}% de {sequence}");
