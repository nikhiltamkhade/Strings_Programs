using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Checkvowelsispresent
    {


        public static void Main(string[] args)
        {
            Console.WriteLine(StringContainsVowelsMethod("Hello")); // true
            Console.WriteLine(StringContainsVowelsMethod("TV")); // false
        }

        public static bool StringContainsVowelsMethod(string input)
        {
            return Regex.IsMatch(input.ToLower(), ".*[aeiou].*");
        }
    }
}
