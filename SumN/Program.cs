using System;

namespace SumN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer: ");
            string n = Console.ReadLine();
            int num = -1;
            if (!int.TryParse(n, out num)){
                Console.WriteLine("Not an integer");
            } else {
               
            }
                
        }  
    }
}

