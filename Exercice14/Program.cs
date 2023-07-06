Console.WriteLine("--- Quelle taille dois-je prendre ? ---\n");
Console.Write("Entrez votre taille (en cm) : ");
double height;
while(!double.TryParse(Console.ReadLine(), out height))
{
    Console.Write("Vous devez entrer un nombre : ");
}
Console.Write("Entrez votre poids (en kg) : ");
double weight;
while (!double.TryParse(Console.ReadLine(), out weight))
{
    Console.Write("Vous devez entrer un nombre : ");
}
int size = 0;
if(height > 183 || height < 145 || weight > 77 || weight < 43)
{
    Console.WriteLine("Aucune taille ne vous correspond.");
    return;
} else if((weight <= 47 && height < 172) ||
    (weight <= 53 && height < 169) ||
    (weight <= 59 && height < 166) ||
    (weight <= 65 && height < 163))
{
    size = 1;
} else if((weight >= 48 && weight <= 53 && height >= 169 && height < 183) ||
    (weight >= 54 && weight <= 59 && height >= 166 && height < 178) ||
    (weight >= 60 && weight <= 65 && height >= 163 && height < 175) ||
    (weight >= 66 && weight <= 71 && height >= 160 && height < 172))
{
    size = 2;
} else if((weight >= 72 && height >= 163) ||
    (weight >= 66 && height >= 172) ||
    (weight >= 60 && height >= 175) ||
    (weight >= 54 && height >= 178))
{
    size = 3;
}
Console.WriteLine($"La taille qui vous correspond est la taille {size}");