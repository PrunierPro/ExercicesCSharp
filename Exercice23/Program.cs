Console.WriteLine("--- Acroissement de population ---");
int pop = 96809;
int years;
for(years = 0; 96809 * Math.Pow(1 + 0.0089, years) <= 120000; years++)
{
    // Do nothing
}
pop = (int)Math.Round(96809 * Math.Pow(1 + 0.0089, years));
Console.WriteLine($"Il faudra {years} ans, nous serons en {2015 + years}");
Console.WriteLine($"Il y aura {pop} habitants en {2015 + years}");