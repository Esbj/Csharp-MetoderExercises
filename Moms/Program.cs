using System;

namespace Moms
{
    class Program
    {
        static double Moms (double noMoms){
            double momsValue = noMoms / 4;
            double plusMoms = momsValue + noMoms;
            return plusMoms;
        }
        static void Main(string[] args)
        {
            //Skapa en metod som lägger till momsen på en viss summa. Antag att
            //momsen är 25 %.

            Console.WriteLine("Ange priset du vill lägga till momms på:");


            
            int intCost = Convert.ToInt32(Console.ReadLine());
            double doubleCost = Convert.ToDouble(intCost);
            Console.WriteLine(Moms(doubleCost));


        }
    }
}
