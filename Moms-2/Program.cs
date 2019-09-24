using System;

namespace Moms
{
    class Program
    {
        //Funktionen tar in 2 värden: Pris och Moms och returnerar pris + moms.
        static double Moms(double price, double moms)
        {
            double deciMoms = moms/100;
            double fullPrice = deciMoms+price;
            return fullPrice;

        }
        static void Main(string[] args)
        {
            //Skapa en metod som lägger till momsen på en viss summa. Antag att
            //momsen är 25 %.


            // Gör om funktionen så att man i
            // metodanropet(via parameterlistan) får ange vad momsen ligger på.



            //Tar in pris från användaren och gör om till värde som funktionen behöver
            Console.Write("Ange priset du vill lägga till momms på: ");
            double priceInput = Convert.ToDouble(Console.ReadLine());
            //Tar in värde på moms
            Console.Write("Ange nuvarande moms: ");
            double momsInput = Convert.ToDouble(Console.ReadLine());

            //Kalla på funktionen och skriv ut
            double pris = Moms(priceInput, momsInput);
            Console.WriteLine("Pris inklusive moms = "+pris);



        }
    }
}
