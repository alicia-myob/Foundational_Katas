﻿using System;
using System.Linq;

namespace SumN
{
    class Program
    {
        public static void Sum(long num)
        {
            if (num == 0){
                Console.WriteLine("0");
            } else {
                int[] array = new int[num];
                for (int i = 0; i < num; i++){
                    array[i] = i+1;
                }
                long sumArray = array.Sum();
                Console.WriteLine("Sum: " + sumArray + "\n");
            }
            
        }  
    }
}

