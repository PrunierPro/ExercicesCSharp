int[] tabAscii = new int[26];
for (int i = 0; i < tabAscii.Length; i++) // remplissage
{
    tabAscii[i] = i + 'A';
}
Console.WriteLine("--- L'alphabet ASCII ---");
for (int i = 0; i < tabAscii.Length; i++) // affichage
{
    Console.WriteLine($"{tabAscii[i]} = {(char)tabAscii[i]}");
}
