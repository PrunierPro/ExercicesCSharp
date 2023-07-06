Console.WriteLine("--- Quelle boisson souhaitez-vous ? ---\n");
Console.WriteLine(@"Liste des boissons disponibles : 
    1)Eau Plate
    2)Eau gazeuse
    3)Coca-Cola
    4)Fanta
    5)Sprite
    6)Orangina
    7)7UP");
Console.Write("\nFaites votre choix (1 à 7) : ");
int choice;
while(!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 7)
{
    Console.Write("Vous devez entrer un chiffre entier entre 1 et 7 inclus : ");
}
//string boisson = "boisson";
//switch (choice)
//{
//    case 1: boisson = "Eau Plate";
//        break;
//    case 2: boisson = "Eau gazeuse";
//        break;
//    case 3: boisson = "Coca-Cola";
//        break;
//    case 4: boisson = "Fanta";
//        break;
//    case 5: boisson = "Sprite";
//        break;
//    case 6: boisson = "Orangina";
//        break;
//    case 7: boisson = "7Up";
//        break;
//}
string[] boissons = { "Eau Plate", "Eau Gazeuse", "Coca-Cola", "Fanta", "Sprite", "Orangina", "7Up" };
Console.WriteLine($"\nVotre {boissons[choice-1]} est servi...");