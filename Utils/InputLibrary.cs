namespace InputUtilsLibary
{
    public static class InputLibrary
    {
       
        public static void inputControlDouble(double input)
        {
            while(!double.TryParse(Console.ReadLine(), out input))
            {
                Console.Write("Vous devez entrer un nombre : ");
            }
        }
    }
}