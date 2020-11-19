using System;

namespace SumOrProduct{
    class Product{

        public static void prod(long num){
            long ans = 1;
            for (int i = 1; i < num + 1; i++){
                ans = ans * i;
            }
            Console.WriteLine(ans);
        }
    }
}

