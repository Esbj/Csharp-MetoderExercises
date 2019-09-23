using System;

namespace Add_Strings
{
    class Program
    {
        static string addStrings (string string1, string string2){
            string addedString = string1 +" "+string2;
            return addedString;
        }
        static void Main(string[] args)
        {
            // Skapa en metod som tar in två string variabler, lägger samman dessa och
            // returnerar som en sträng. (Tex. Strängarna ”Hej på dig!” och ” Hur mår
            // du?” blir ”Hej på dig! Hur mår du?”.
            Console.WriteLine("Skriv in två namn: ");
            string namn = addStrings(Console.ReadLine(), Console.ReadLine());
            Console.WriteLine(namn);
        }
    }
}
