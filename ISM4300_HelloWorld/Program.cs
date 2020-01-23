// Name: Amanda Blakley
// Date: 1/21/2020
// Project: Deliverable 1 - "Hello World"
// Description: Creates a basic console application that displays the message "Hello World!". 

using System;

namespace ISM4300_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pause to prior to displaying "Hello World!"
            Console.WriteLine("Press any key to continue...");

            // Creates a space 
            Console.WriteLine("   ");

            // Write a line that states "Hello World!"
            Console.WriteLine("Hello World!");

            // Console is active so user can read the message. 
            // Press any key to exit the application 
            Console.ReadKey(true);
        }
    }
}
