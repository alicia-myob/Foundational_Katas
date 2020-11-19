using System;

namespace SumOrProduct
{
    class Program
    {
        static void Main(string[] args)
        {   
            bool ask = true;
            bool run = true;
            while (run){
                Console.WriteLine("Enter a positive integer: ");
                string n = Console.ReadLine();
                int num = -1;
                if (!int.TryParse(n, out num)){
                    Console.WriteLine("Not an integer. Please enter a positive integer: ");
                } else if (num < 0){
                    Console.WriteLine("Negative number detected! Please enter a positive integer: ");
                } else {
                    int number = Int32.Parse(n);
                    bool sump = true;
                    while(sump){
                        Console.WriteLine("Would you like to calculate the sum or the product of 1 to " + n + " ? (s/p): ");
                        string ans = Console.ReadLine();
                        if (ans.Equals("s")){
                            SumN.Program.Sum(number);
                            sump = false;
                        } else if (ans.Equals("p")){
                            
                        } else {
                            Console.WriteLine("Invalid input. Please try again! ");
                        }
                    }
                    
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
}
