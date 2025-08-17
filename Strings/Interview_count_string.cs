using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Interview_count_string
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in input)
            {

                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            foreach (var item in charCount)
            {
                Console.WriteLine($"{item.Key}={item.Value}");
            }
            Console.ReadLine();
        }
    }
}
