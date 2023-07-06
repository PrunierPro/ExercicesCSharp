Console.WriteLine("--- Quelle est la nature du triangle ? ---\n");
Console.Write("Entrez la longeur du segment AB (en cm) : ");
double ab;
while(!double.TryParse(Console.ReadLine(), out ab))
{
    Console.Write("Vous devez entrer un nombre : ");
}
Console.Write("Entrez la longeur du segment BC (en cm) : ");
double bc;
while (!double.TryParse(Console.ReadLine(), out bc))
{
    Console.Write("Vous devez entrer un nombre : ");
}

Console.Write("Entrez la longeur du segment CA (en cm) : ");
double ca;
while (!double.TryParse(Console.ReadLine(), out ca))
{
    Console.Write("Vous devez entrer un nombre : ");
}
if(ab == bc)
{
    if(bc == ca)
    {
        Console.WriteLine("Le triangle est équilatéral");
    } else
    {
        Console.WriteLine("Le triangle est isoclèle en B, mais n'est pas équilatéral.");
    }
} else if(ab == ca)
{
    Console.WriteLine("Le triangle est isocèle en A, mais n'est pas équilatéral.");
} else if(bc == ca)
{
    Console.WriteLine("Le triangle est isocèle en C, mais n'est pas équilatéral");
} else
{
    Console.WriteLine("Le triangle n'est ni équilatéral ni isocèle en A, B, ou C.");
}
