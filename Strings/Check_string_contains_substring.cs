using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Check_string_contains_substring
    {
        static void Main(string[] args)
        {
            string senetence = "ganjibhoyare is my village";
            bool containsword = senetence.Contains("is");
            Console.WriteLine(containsword);// true
        }
    }
}
