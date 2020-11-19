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
                num = Int32.Parse(n);
                if (num == 0){
                    Console.WriteLine("0");
                } else {

                }
            }
                
        }  
    }
}

