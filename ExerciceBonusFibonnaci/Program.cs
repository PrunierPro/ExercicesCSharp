Console.WriteLine("--- Suite de Fibonnaci ---\n");
Console.Write("Saisir un nombre : ");
int number;
while(!int.TryParse(Console.ReadLine(), out number) || number < 0)
{
    Console.Write("Vous devez saisir un nombre entier positif : ");
}
int result = 1;
int prevResult = 0;
int spaces = 0;
do
{
    int tmp = prevResult;
    prevResult = result;
    result += tmp;
    string spaceString = string.Concat(Enumerable.Repeat(" ", spaces));
    Console.WriteLine($"\t{spaceString + result}"); ;
    spaces++;
} while (result < number);
