using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Revese_word
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string input=Console.ReadLine();    

            char[] chararray=input.ToCharArray();
            Array.Reverse(chararray);
            string rev=new string(chararray);  // this is optional

            Console.WriteLine(rev);

        }
    }
}
