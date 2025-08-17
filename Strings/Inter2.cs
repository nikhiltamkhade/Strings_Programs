using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Inter2
    {
        static void Main(string[] args)
        {
            string nt = "nikehil";
            string vowels = "aeiouAEIOU";
            int count = 0;

            for (int i = 0; i < nt.Length; i++)
            {
                if (vowels.Contains(nt[i]))
                {
                    count++;

                    if (count == 2)
                    {

                        Console.WriteLine(i);
                    }
                }

            }
        }
    }
}
