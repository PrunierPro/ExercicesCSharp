//CARRE
Console.WriteLine("--- Calcul du périmètre et de l'aire d'un carré ---");
Console.Write("Entrez la longeur d'un coté du carré (en cm) : ");
double squareLength;
while (!double.TryParse(Console.ReadLine(), out squareLength))
{
    Console.Write("Vous devez entrer un nombre : ");
}
Console.WriteLine($"Le périmètre du carré est : {squareLength * 4} cm");
Console.WriteLine($"L'aire du carré est : {squareLength * squareLength} cm2");

//RECTANGLE
Console.WriteLine("--- Calcul du périmètre et de l'aire d'un rectangle ---");
Console.Write("Entrez la longeur du rectangle (en cm) : ");
double length;
while (!double.TryParse(Console.ReadLine(), out length))
{
    Console.Write("Vous devez entrer un nombre : ");
}
Console.Write("Entrez la largeur du rectangle (en cm) : ");
double width;
while (!double.TryParse(Console.ReadLine(), out width))
{
    Console.Write("Vous devez entrer un nombre : ");
}
Console.WriteLine($"Le périmètre du rectangle est : {length * 2 + width * 2} cm");
Console.WriteLine($"L'aire du rectangle est : {length * width} cm2");
