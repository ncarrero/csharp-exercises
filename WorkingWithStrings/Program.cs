using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)

            //formatting strings
        {
            //backslash character (\) allows you to put special characters, insert line feeds into a literal string
            //string myString = "My \"so-called\" life.";

            //insert a newline character to break a string apart into multiple lines (no spaces or else it'll be in string)
            //string myString = "What if I need to add a\nnew line?";

            //need to use a backslash \ character in string: add another backslash character to exit out but will still
            //show original backslash
            //string myString = "Go to your c:\\ drive.";
            //OR you can put the @ symbol in front of the string to say you want to use backslash characters as 
            //actual backslash characters in the string
            //string myString = @"Go to your c:\ drive.";

            //insert replacement code so it can be reused
            //string myString = string.Format("{0} = {1}", "First", "Second");

            //display something to the end user using currency by adding colon C after replacement code
            //string myString = string.Format("{0:C}", 123.45);

            //display really long number by adding colon N after replacement code
            //string myString = string.Format("{0:N}", 1234567890);

            //display as a percent
            //string myString = string.Format("Percentage is: {0:P}", .123);

            //create a custom format by adding # symbols to show formatting
            //string myString = string.Format("Phone Number: {0: (###) ###-####}", 1234567890);

            //change or manipulate strings

            //string myString = "   That summer we took threes across the board   ";
            //substring helper method: start at specific point and grab everything until the ending point
            //myString = myString.Substring(6, 14);


            //create all uppercase letters in string
            //myString = myString.ToUpper();

            //replace a character with another character
            //myString = myString.Replace(" ", "--");

            //remove subset/section of characters in a string
            //myString = myString.Remove(6, 14);

            //remove characters before or after string (like extra whitespace)
            //can use Length property on arrays or strings
            //myString = string.Format("Length before: {0} -- Length after: {1}", myString.Length, myString.Trim().Length);

            //concatenate (add on) double dashes to the string up to 100 times
            //takes up too much data and time with larger strings
            /*
             * string myString = "";
            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            //use string builder to create a new class instead of example above, then append to the most current string
            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
