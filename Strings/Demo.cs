using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            string st = "nin";

            char[] ch = st.ToCharArray();

            Array.Reverse(ch);

            string s=new string(ch);

            if (st == s)
            {
                Console.WriteLine("string is palindrom");
            }
            else
            {
                Console.WriteLine("string is not palindrom");
            }








            

        }
    }
}
