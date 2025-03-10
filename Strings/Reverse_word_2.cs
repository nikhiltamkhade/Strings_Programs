using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Reverse_word_2
    {
        //static void Main(string[] args)
        //{
        //    Console.Write(" Enter the sentence");
        //    string input=Console.ReadLine();

        //    string[] words = input.Split(' ');

        //    string reversestring = " ";
        //    foreach (string word in words)
        //    {
        //        string reverseword = "";

        //        for (int i = word.Length - 1; i >= 0; i--)
        //        {
        //            reverseword = reverseword + word[i];
        //        }
        //        reversestring = reversestring + reverseword;    
        //    }

        //    Console.Write(reversestring.Trim());

        //}



        static void Main()
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            // Reverse the entire sentence
            string reversedSentence = new string(input.Reverse().ToArray());

            Console.WriteLine("Reversed sentence: " + reversedSentence);
        }
    }
}
   