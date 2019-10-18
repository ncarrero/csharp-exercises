using System;


//Prepwork 3.1 Exercises #2: Numeric Types: Write a program to calculate the area of a rectangle and print the answer
//to the console.  You should prompt the user for dimensions. (What data types should the dimensions be?)
namespace HelloWorldRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the width of your rectangle: ");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Please enter the length of your rectangle: ");
            string userInput2 = Console.ReadLine();
            int width = int.Parse(userInput1);
            int length = int.Parse(userInput2);
            int area = length * width;
            Console.WriteLine("The area of your rectangle is " + area + " square units.");
            Console.ReadLine();
        }
    }
}
