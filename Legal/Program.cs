using System;

namespace legal
{
    class Program
    {
        static bool legal (int age){
            if (age < 18){
                return false;
            }else{
                return true;
            }
        }
        static void Main(string[] args)
        {
            //Skapa en metod som kontrollerar om man är myndig.
            //Metoden ska ta in ett heltal och returnera true eller false.
            
            
           Console.WriteLine("Ange din ålder: ");
           int ålder = Convert.ToInt32(Console.ReadLine());
           bool myndig = legal(ålder);
           if (myndig){
            Console.WriteLine("Du är myndig!");
           }else{
            Console.WriteLine("Du är inte myndig!");
           }
        }
    }
}
