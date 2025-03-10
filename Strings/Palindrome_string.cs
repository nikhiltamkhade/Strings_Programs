using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Palindrome_string
    {
        static void Main(string[] args)
        {
            string n = "Nink".ToLower();

           // string n =nt.ToLower();

            char[] ch = n.ToCharArray(); // converted string to char array

            Array.Reverse(ch);

            string reverse = new string(ch);  // converted char array into string 

            if (n == reverse)
            {
                Console.WriteLine("string is palindrome");
            }
            else
            {
                Console.WriteLine("string is not palindrom");
            }

            Console.ReadLine();
        }
    }
}
