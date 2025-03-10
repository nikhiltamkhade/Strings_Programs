using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Demo
    {
        static void Main(string[] args)
        {
            string n = "this is string count program";
            int count = 0;
            for (int i = 0; i < n.Length; i++) {

                if (n[i]!=' ')
                {
                    count++;
                }
               
            }
            Console.WriteLine(count);
        }
    }
}
