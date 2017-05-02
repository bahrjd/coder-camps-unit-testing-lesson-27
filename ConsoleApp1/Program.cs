using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tada = new Classy { Who = "you", When = "now" };
            Console.WriteLine(tada);
            Console.ReadLine();
        }
    }
}