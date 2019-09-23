using System;

namespace Add_Numbers
{
    //Skapa metoden Addera() som tar in två heltal och returnerar summan.
    class Program
    {
        static int Addera (){
            int tal1 = Convert.ToInt32(Console.ReadLine());
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int summa = tal1 + tal2;
            return summa;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in 2 heltal: ");
            int summa = Addera();
            Console.WriteLine("Summan är "+summa);
        }
    }
}
