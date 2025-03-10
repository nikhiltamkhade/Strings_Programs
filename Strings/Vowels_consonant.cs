using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Vowels_consonant
    {
        static void Main(string[] args)
        {
            int vcount = 0, ccount = 0;
           // string nt = string.Empty;      this is for print vowels character

            string nikhil = "My name Is an Nikhil";

            nikhil = nikhil.ToLower();

            for (int i = 0; i < nikhil.Length; i++)
            {

                if (nikhil[i] == 'a' || nikhil[i] == 'e' || nikhil[i] == 'i' || nikhil[i] == 'o' || nikhil[i] == 'u')
                {
                   // nt = nt + nikhil[i];
                   vcount++;
                }
                else if (nikhil[i] >= 'a' && nikhil[i] <= 'z')
                {
                    ccount++;
                }

            }

            Console.WriteLine("vowels is" + vcount);
            Console.WriteLine("consonent is" + ccount);
          //  Console.WriteLine("vowels are"+nt);

        }
    }
}