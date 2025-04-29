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
            string n = "Nink";
            n=n.ToLower();

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
        // this below logic is made myself and best 
        //static void Main(string[] args)
        //{
        //    string Sen = "NiNkh";
        //    Sen = Sen.ToLower();
        //    string s = "";
        //    Char[] csen = Sen.ToCharArray();

        //    for (int i = Sen.Length - 1; i >= 0; i--)
        //    {

        //        s = s + Sen[i];

        //    }
        //    if (s == Sen)
        //    {
        //        Console.WriteLine("string is palindrom");
        //    }
        //    else
        //    {
        //        Console.WriteLine("string is not palindrom");
        //    }
        //    Console.ReadLine();
        //}


    }
}
