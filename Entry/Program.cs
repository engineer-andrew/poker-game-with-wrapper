using System;
using Shuffler;

namespace Entry
{
    class Program
    {
        static void Main(string[] args)
        {
            var shuffler = new Cards();
            shuffler.Shuffle();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}