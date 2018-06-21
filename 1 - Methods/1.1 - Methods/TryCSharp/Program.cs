using System;

namespace TryCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of your band?");
            string name = Console.ReadLine();
            AnnounceBand(name);
        }

        static void AnnounceBand(string bandName)
        {
            Console.WriteLine("Welcome " + bandName + " to the stage!");
        }
    }
}
