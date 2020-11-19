using System;

namespace SumOddN
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run){
                bool ask = true;
                Console.WriteLine("Enter a positive integer");
                string n = Console.ReadLine();

                int num = -1;
                if (!int.TryParse(n, out num)){
                    Console.WriteLine("Not an integer. Please enter a positive integer: ");
                } else if (num < 0){
                        Console.WriteLine("Negative number detected! Please enter a positive integer: ");
                } else {
                    num = Int32.Parse(n);
                    
                    if (num == 0){
                        Console.WriteLine("0");
                    } else {
                        int sum = 0;
                        
                        for (int i = 1; i < num+1; i++){
                            if ((i % 3 == 0) || (i % 5 == 0)){
                                sum+=i;
                            }
                        }

                        Console.WriteLine("Sum: " + sum);
                        while (ask){
                            Console.WriteLine("Would you like to enter another number? (y/n): ");
                            string cont = Console.ReadLine();
                            if (cont.Equals("n", StringComparison.OrdinalIgnoreCase)){
                                ask = false;
                                run = false;
                                Console.WriteLine("Thanks for using SumOddN!");
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
}
