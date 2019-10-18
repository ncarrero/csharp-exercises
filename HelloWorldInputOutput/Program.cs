using System;


//PrepWork 3.1 Exercises #1: Input/Output: Modify your HelloWorld program to prompt the user for their name, 
//and greet them by name.
namespace HelloWorldInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            string userInput = Console.ReadLine();
            Console.WriteLine("Hello, " + userInput);
            Console.ReadLine();
        }
    }
}
