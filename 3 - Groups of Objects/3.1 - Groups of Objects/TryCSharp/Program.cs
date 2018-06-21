using System;

namespace TryCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your band?");
            Band band = new Band();
            band.Name = Console.ReadLine();
            band.Announce();
        }
    }
}
