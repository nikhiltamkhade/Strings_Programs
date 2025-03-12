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
            string nt = "nikhil";
            int vcount = 0;
            int ccount = 0;

            for (int i = 0; i < nt.Length; i++) {

                if (nt[i] == 'e' || nt[i] == 'i')
                {
                    vcount++;   
                }
                else if (nt[i]>'a' && nt[i] < 'z')
                {

                    ccount++;  
                }

            }

            Console.WriteLine(ccount);  
            Console.WriteLine(vcount);
           

        } 
    }
}
