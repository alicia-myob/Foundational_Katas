using System;
using System.Linq;

namespace SumN
{
    class Program
    {
        public static void Sum(int n)
        {
            int num = Int32.Parse(n);
            
            if (num == 0){
                Console.WriteLine("0");
            } else {
                int[] array = new int[num];
                for (int i = 0; i < num; i++){
                    array[i] = i+1;
                }
                int sumArray = array.Sum();
                Console.WriteLine("Sum: " + sumArray + "\n");
            }
            
        }  
    }
}

