Console.WriteLine("Insertion des valeurs du tableau :");
int[] tab = new int[10];
Console.Write("Insérer les valeurs automatiquement ? (Y/N) ");
if (Console.ReadLine().ToUpper().Equals("Y")) tab = saisieAutomatique();
else
{
    for (int i = 0; i < tab.Length; i++)
    {
        Console.Write($"Saisir la valeur {i + 1} : ");
        while (!int.TryParse(Console.ReadLine(), out tab[i]))
        {
            Console.Write("Veuillez entrer un nombre entier : ");
        }
    }
}
Console.WriteLine("Affichage des valeurs du tableau :");
for(int i = 0; i < tab.Length; i++)
{
    string offset = string.Concat(Enumerable.Repeat("\t", i));
    Console.WriteLine(offset + tab[i]);
}

int[] saisieAutomatique()
{
    int[] res = new int[10];
    Random rand = new Random();
    for(int i = 0; i < res.Length; i++)
    {
        res[i] = rand.Next(short.MinValue, short.MaxValue);
    }
    return res;
}
