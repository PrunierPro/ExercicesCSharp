Console.WriteLine("--- Où est passé mon numéro ? ---");
Console.WriteLine("Affectation des valeurs...");
int[] tab = new int[10];
Random rand = new Random();
for(int i = 0; i < tab.Length; i++)
{
    tab[i] = rand.Next(1, 51); 
}

Console.WriteLine("Affichage avant triage :\n");
string offset = default;
foreach(int number in tab)
{
    Console.WriteLine(offset + number);
    offset += "  ";
}

int firstNum = tab[0];

Array.Sort(tab);

Console.WriteLine("Affichage après triage :\n");
offset = default;
foreach (int number in tab)
{
    Console.WriteLine(offset + number);
    offset += "  ";
}

Console.WriteLine($"\nLe nombre {firstNum} se trouvait en 1ere position.\nIl se retrouve en position {Array.IndexOf(tab, firstNum) + 1} après le triage.");