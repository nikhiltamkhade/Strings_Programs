using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Revese_string
    {
        static void Main(string[] args)
             {
                string s = "nikhil";
                string ss = "";

                for (int i = s.Length - 1; i >= 0; i--)
                {
                    ss = ss + s[i];
                }

                Console.WriteLine(ss);  
                Console.ReadLine();


            }

    }
}
