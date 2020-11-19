using System;

namespace UserGreeting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type your username and press enter
            Console.WriteLine("Enter your name: ");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Hello " + userName);
        }
    }
}
