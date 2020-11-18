//Namespace which contains commonly used types
using System;

//equivalent to "package"
Namespace PrintHelloWorld {

    //class
    class hello{

        //entry point of the program 
        static void main(String[] args){

            Console.WriteLine("Hello World!");

            //Makes the system wait for a key press and prevents the screen from closing quickly
            Console.ReadKey();
        }
    }
}

