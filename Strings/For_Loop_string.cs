using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class For_Loop_string
    {
        static void Main(string[] args)
        {
            string[] nt = { "nikhil", "akshay", "swapnil", "aniket", "avinash" };

            for(int i = 0; i < nt.Length; i++)
            {
                Console.WriteLine(nt[i]);
            }
        }
    }
}
