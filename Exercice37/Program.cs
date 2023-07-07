Console.WriteLine("Enumération d'un tableau avec un foreach :");
string[] months = { "Janvier", "Fevrier", "Mars", "Avril", "Mais", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };
string offset = default;
foreach(string month in months)
{
    offset += "\t";
    Console.WriteLine(offset + month);
}
