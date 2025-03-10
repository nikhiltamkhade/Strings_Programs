using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Dublicate_character
    {
        static void Main(string[] args)
        {
            string Dublicate = "Nikhiln";

           // string Ld = Dublicate.ToLower();

            char[] chararray = Dublicate.ToCharArray();

            for (int  i = 0; i < chararray.Length; i++)
            {
                for (int j = i+1; j < chararray.Length; j++)
                {

                    if (chararray[i] == chararray[j]&& chararray[i]!=' ')
                    {
                        Console.WriteLine(chararray[j]);
                    }
                }
            }
        }
    }
}
