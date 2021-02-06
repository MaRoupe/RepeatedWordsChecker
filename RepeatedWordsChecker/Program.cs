using System;
using System.Collections.Generic;
using System.Linq;

namespace RepeatedWordsChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take the sentence and separate the words.

            string textString = "";

            while ((textString = Console.ReadLine()) != null)
            {
                string[] wordSplit = textString.Split(" ");

                //Check if any of the words are repeated.
                string testAnswer = "";

                testAnswer = (!wordSplit.All(new HashSet<string>().Add)) ? "no" : "yes";

                // Print Yes or No depending on if a word is repeated.
                Console.WriteLine(testAnswer);
            }
        }
    }
}
}
