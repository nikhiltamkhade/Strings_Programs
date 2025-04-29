using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Inter
    {
        static void Main(string[] args)
        {
            string nt = "nikhil";

            int vcount=0;

            for(int i = 0; i < nt.Length; i++)
            {
                if (nt[i] == 'a' || nt[i] == 'e' || nt[i] == 'i' || nt[i] == 'o' || nt[i]=='u')
                {
                    char ch=nt[i];

                    if ("aeiou".IndexOf(ch) >= 0) { 
                    
                        vcount++;

                        if (vcount == 2) { 
                        
                            Console.WriteLine(" second vowel"+ch+"found at position"+i);
                        
                        }
                    

                    }



                }




            }






        }
    }
}
