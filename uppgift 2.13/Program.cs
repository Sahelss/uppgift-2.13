using System;

namespace Uppgift_2_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lön för Gustav"); //Här ska man skriva in lönen för de anställda
            int Gustav = int.Parse(Console.ReadLine());
            Console.WriteLine("Lön för Zakki");
            int Zakki = int.Parse(Console.ReadLine());
            Console.WriteLine("Lön för Samme");
            int Samme = int.Parse(Console.ReadLine());

            Console.WriteLine((Gustav + Zakki + Samme) / 3); //Här är räkningen 
        }
    }
}
