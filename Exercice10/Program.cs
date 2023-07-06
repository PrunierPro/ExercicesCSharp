Console.WriteLine("--- La lettre est-elle une voyelle ? ---\n");
Console.Write("Entrez une lettre : ");
string letter = Console.ReadLine().ToUpper();
while (letter.Length > 1)
{
    Console.Write("Vous ne devez entrer *qu'une seule* lettre : ");
    letter = Console.ReadLine().ToUpper();
}
string vowels = "AEIOU";
if(vowels.Contains(letter))
{
    Console.WriteLine("Cette lettre est une voyelle !");
} else
{
    Console.WriteLine("Cette lettre n'est pas une voyelle !");
}

