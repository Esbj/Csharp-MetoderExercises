using System;

namespace To_Percentage
{
    class Program
    {
        static int ToPercentage(double input){
            int precentageValue = Convert.ToInt32(input)*100;
            return precentageValue;
        }
        static void Main(string[] args)
        {
            // Skapa metoden ToPercentage() som tar in ett decimaltal och returnerar ett heltal.
            Console.Write("Mata in ett decimaltal för att få procentuellt värdde: ");
            double toConvert = Convert.ToDouble(Console.ReadLine());
            int convertedNumber = ToPercentage(toConvert);
            Console.WriteLine("Värdet i procent är: "+convertedNumber+"%");
        }
    }
}
