Console.Write("Veuillez entrer un nombre : ");
int lines;
while (!int.TryParse(Console.ReadLine(), out lines))
{
    Console.Write("Vous devez entrer un nombre : ");
}
Console.Clear();
for(int line = 0; line < lines; line++)
{

}
