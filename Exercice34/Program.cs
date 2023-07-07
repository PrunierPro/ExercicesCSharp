Console.WriteLine("--- Est-pair...? Est impair...? ---");
Console.Write("Combien de nombre(s) contiendra le tableau ? ");
int n;
while(!int.TryParse(Console.ReadLine(), out n) || n < 0)
{
    Console.Write("Vous devez saisir un nombre entier positif : ");
}
int[] tab = new int[n];
Console.WriteLine("Affection automatique des valeurs...\n");
Random rand = new Random();
for(int i = 0; i < n; i++)
{
    tab[i] = rand.Next(1, 51);
}
Console.WriteLine("Verification des valeurs du tableau :");
for(int i = 0; i < n; i++)
{
    Console.WriteLine($"\tLe nombre {tab[i]} est {(tab[i] % 2 == 0 ? "pair" : "impair")}.");
}
