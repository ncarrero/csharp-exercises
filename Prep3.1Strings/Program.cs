using System;
//Class Prep 3.1 Exercises #4: The first sentence of Alice's Adventures in Wonderland is below.
//Store this sentence in a string, and then prompt the user for a string to search for within this string.
//Print whether or not the search term was found.  See if you can make the search case-insensitive, so that searching
//for "alice" prints true.
namespace Prep3._1Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //define original string and convert to all lowercase letters
            string sentenceOriginal = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            string sentence = sentence.ToLower();

            Console.WriteLine("Please enter a phrase you think is in the first line of Alice in Wonderland.");
            string userInput = Console.ReadLine();

            inSentence

            if false {
                Console.WriteLine(userInput + "is not in the sentence.");
            }

            else
            {
                Console.WriteLine(userInput + "is in the sentence.");
            }
        }
    }
}

//            Console.WriteLine("Please enter the amount of miles driven: ");
//string userInput1 = Console.ReadLine();
//Console.WriteLine("Please enter the amount of gas consumed (in gallons): ");
//            string userInput2 = Console.ReadLine();
//int miles = int.Parse(userInput1);
//int gas = int.Parse(userInput2);
//int mpg = miles / gas;
//Console.WriteLine("The miles-per-gallon you've driven is " + mpg + ".");
//            Console.ReadLine();