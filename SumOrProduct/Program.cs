using System;

namespace SumOrProduct
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.WriteLine("Enter a positive integer: ");
            string n = Console.ReadLine();
            int num = -1;
            if (!int.TryParse(n, out num)){
                Console.WriteLine("Not an integer. Please enter a positive integer: ");
            } else if (num < 0){
                    Console.WriteLine("Negative number detected! Please enter a positive integer: ");
            } else {
                while (ask){
                    Console.WriteLine("Would you like to enter another number? (y/n): ");
                    string cont = Console.ReadLine();
                    if (cont.Equals("n", StringComparison.OrdinalIgnoreCase)){
                        ask = false;
                        run = false;
                        Console.WriteLine("Thanks for using SumN!");
                    } else if (cont.Equals("y", StringComparison.OrdinalIgnoreCase)){
                        ask = false;
                        run = true;
                    } else {
                        try {
                            throw new System.ArgumentException();
                        } catch {
                            Console.WriteLine("Please type y for yes, n for no");
                            ask = true;
                        }
                    }
                }
            }
        }
    }
}
