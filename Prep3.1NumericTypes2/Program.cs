using System;
//Class Prep 3.1 Exercises #3: Write a program that asks a user for the number of miles they have driven and the
//amount of gas they've consumed (in gallons) and print their miles-per-gallon.
namespace Prep3._1NumericTypes2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the amount of miles driven: ");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Please enter the amount of gas consumed (in gallons): ");
            string userInput2 = Console.ReadLine();
            int miles = int.Parse(userInput1);
            int gas = int.Parse(userInput2);
            int mpg = miles / gas;
            Console.WriteLine("The miles-per-gallon you've driven is " + mpg + ".");
            Console.ReadLine();
        }
    }
}
