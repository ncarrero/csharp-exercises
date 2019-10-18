using System;

//namespace called HelloWorld (same as name of application)
namespace HelloWorld
{
    //class called program (all methods that are related to each other), can have multiple classes
    class Program
    {
        //first method (block of code with a name) that is called when application is executed
        static void Main(string[] args)
        {
            //all code is written in the innermost curly braces (code blocks)
            //semicolons complete thought in c# (whitespace doesn't matter)
            //can put lines of code on separate lines or multiple thoughts on one line

            //call into and use framework class library to display text in a console window
            //Console class is going to find the method WriteLine in the class library
            Console.WriteLine("Hello World!");
            //tell application to wait for input from user in order to continue or exit out of window
            //parentheses will invoke the function
            Console.ReadLine();
        }
    }
}
