using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Remove_spcae_string
    {
        // you can remove space using trim(),replace()
        static void Main(string[] args)
        {
            string str = "   nikhil is my name";
            string replace = str.Replace(" ", "");
            Console.WriteLine(replace);

            string useingtrim=str.Trim();
            Console.WriteLine(useingtrim);

        }
    }
}
