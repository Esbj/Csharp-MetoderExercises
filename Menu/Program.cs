using System;

namespace Menu
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("1: Addera nummer");
            Console.WriteLine("2: Väder");
            Console.WriteLine();
            Console.WriteLine();
            return;
        }
        static void numberAdder()//val 1
        {
            Console.WriteLine("Ange två nummer som ska adderas");
            int[] numbers = new int[2];
            numbers[0] = Convert.ToInt32(Console.ReadLine());
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            int sum = numbers[1] + numbers[2];
            Console.WriteLine("Summan av talen är: " + sum);
            return;
        }
        static void weather()//val 2
        {
            Console.WriteLine("Vad är det för väder?");
            string väder = Console.ReadLine();
            väder.ToUpper();
            char input = väder[0];
            if (input == 'S'){
                Console.WriteLine("Gå ut med dig ditt slöa as!");
            }else if (input == 'R'){
                Console.WriteLine("Okej du får stanna inne men rör på dig lite ändå!");
            }
        }
        static void Main(string[] args)
        {
            // Skapa ett program med menyval. I menyn får man välja att exekvera olika uppgifter. 
            // Alla menyalternativ ska ligga i metoder. 
            // Du kan ta någon uppgift från tidigare övningar men försök att hitta på egna metoder! 

            Console.WriteLine("Välkommen!");
            Console.WriteLine("Välj vilket program du vill köra");
            Menu();
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    numberAdder();
                    break;
                case "2":
                    weather();
                    break;
                case "3":
                    break;

            }
        }
    }
}
