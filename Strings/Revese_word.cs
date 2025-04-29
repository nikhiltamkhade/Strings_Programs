using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Revese_word
    {
        // imp asked in interview 
        static void Main(string[] args)
        {
            string input = " today is my day";

            string[] words = input.Split(' ');  // split into world

            string result = "";

            for (int i = words.Length - 1; i >= 0; i--) {
            
                
                result += words[i]+" ";

            }           
            
            Console.WriteLine(result);

        }
    }
}
