using System;

namespace To_Percentage
{
    class Program
    {
        static int ToPercentage(float input){
            int precentageValue = Convert.ToInt32(input)*100;
            return precentageValue;
        }
        static void Main(string[] args)
        {
            // Skapa metoden ToPercentage() som tar in ett decimaltal och returnerar ett heltal.
            Console.WriteLine("Hello World!");
        }
    }
}
