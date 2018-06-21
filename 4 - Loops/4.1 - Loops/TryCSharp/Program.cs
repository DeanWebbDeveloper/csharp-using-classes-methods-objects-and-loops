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

            Console.WriteLine("Type 'Add' to add a musician.");
            Console.WriteLine("Type 'Announce' to announce the band.");
            Console.WriteLine("Type 'Quit' to quit the application.");

            var repeat = true;
            while(repeat)
            {
                Console.WriteLine("Add, Announce, or Quit?");
                var action = Console.ReadLine();
                if (action == "Add")
                {
                    band.AddMusician();
                }
                else if (action == "Announce")
                {
                    band.Announce();
                }
                else if (action == "Quit")
                {
                    repeat = false;
                }
                else
                {
                    Console.WriteLine(action + " is not a valid command");
                }
            }
        }
    }
}
