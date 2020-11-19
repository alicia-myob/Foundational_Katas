using System;

namespace GreetAliceBob
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            if (name.Equals("Alice", StringComparison.OrdinalIgnoreCase)){
                Console.WriteLine("Hello " + name);
            } else if (name.Equals("Bob", StringComparison.OrdinalIgnoreCase)){
                Console.WriteLine("Hello " + name);
            } else {
                Console.WriteLine("No greeting for you :(");
            }
        }
    }
}
