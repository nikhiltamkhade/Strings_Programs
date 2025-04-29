using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Split_remove
    {
        static void Main(string[] args)
        {
            string nt = "apple,,,,,,,,,. is,fruits";

           // string ta = nt.Split(','); // this is not allowed because split method string[] array

            string[] ta=nt.Split(',');

            foreach (string t in ta)
            {
                Console.WriteLine(t);
            }
           

        }
    }
}
