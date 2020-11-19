using System;

namespace GreetAliceBob
{
    class Program
    {
        bool run = true;
        static void Main(string[] args)
        {
            while (run){
                Console.WriteLine("Enter your name: ");
                var name = Console.ReadLine();
                if (IsString(name)){
                    if (name.Equals("Alice", StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine("Hello " + name);
                    } else if (name.Equals("Bob", StringComparison.OrdinalIgnoreCase)){
                        Console.WriteLine("Hello " + name);
                    } else {
                        Console.WriteLine("No greeting for you :(");
                    }
                    run = false;
                } else {
                    Console.WriteLine("Not a valid string, please enter name again: ");
                }
            }
        }
    }
}
