using System;

namespace Hello
{
    class Program
    {
        static void Hello(string namn){
            Console.WriteLine("Hello "+namn); 
        }
        static void Main(string[] args)
        {
            // Skapa en metod Hello() som tar en string variabel som indata och skriver
            // ut texten med ett annat meddelande

            //Metod syntax:
            // static <void(odefinerat), int, bool, etc..> <namn> (utdata)  {
            //     kod kod kod
            //     ev return 
            // }
            Console.Write("Skriv ditt namn: ");
            Hello(Console.ReadLine());
        }
    }
}
