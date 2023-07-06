Console.WriteLine("--- Question à choix multiple ---\n");
Console.WriteLine(@"Quelle est l'instruction qui permet de sortir d'une boucle en C#?
    a) quit
    b) continue
    c) break
    d) exit");
string trueAnswer = "c";
string answer = default;
string possibleAnswers = "abcd";
do
{
    Console.Write("\nEntrez votre réponse : ");
    answer = Console.ReadLine();
    if (!possibleAnswers.Contains(answer))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ce n'est pas une réponse valide !");
        Console.ResetColor();
        continue;
    }
    else if (answer.ToLower().Equals(trueAnswer))
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nBravo!!! C'est la bonne réponse!");
        Console.ResetColor();
        break;
    } else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Incorrecte!");
        Console.ResetColor();
        Console.Write("Un nouvell essai ? Oui / Non : ");
        if (Console.ReadLine().ToLower().Equals("oui")) continue;
        else break;
    }
} while (!answer.ToLower().Equals(trueAnswer));
