using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var tada = new Classy { Who = "you", When = "now" };
            Console.WriteLine(tada);

            var ski = new Ski();
            ski.LiftTicketCost = 106;
            ski.SkiResort = "Alta";
            Console.WriteLine(ski);

            Console.ReadLine();
        }
    }
}