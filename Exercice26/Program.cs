Console.WriteLine("--- Acroissement de population ---");
int years = 0;
while(96809 * Math.Pow(1 + 0.0089, years) <= 120000)
{
    years++;
}
int pop = (int)Math.Round(96809 * Math.Pow(1 + 0.0089, years));
Console.WriteLine($"Il faudra {years} ans, nous serons en {2015 + years}");
Console.WriteLine($"Il y aura {pop} habitants en {2015 + years}");