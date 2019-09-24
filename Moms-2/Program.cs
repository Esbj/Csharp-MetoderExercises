using System;

namespace Moms
{
    class Program
    {
        //Måste använda double på indatan för att kunna räkna ut momsen då tilldelningsoperatorn tar med 
        //datavärde på referens
        static double Moms (double noMoms){
            //Räknar ut moms och sparar i separat värde
            double momsValue = noMoms / 4;
            //Returnerar pris + moms...
            double plusMoms = momsValue + noMoms;
            return plusMoms;
        }
        static void Main(string[] args)
        {
            //Skapa en metod som lägger till momsen på en viss summa. Antag att
            //momsen är 25 %.



            //Tar in pris från användaren och gör om till värde som funktionen behöver
            Console.WriteLine("Ange priset du vill lägga till momms på:");
            double input = Convert.ToDouble(Console.ReadLine());
            //Kalla på funktionen
            Console.WriteLine(Moms(input));



        }
    }
}
