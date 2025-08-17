using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Inter
    {
        static void Main(string[] args)
        {

            string st = "nikhil";
            int count = 0;
            char tofindv = 'i';

            for (int i = 0; i < st.Length; i++) {

                if (st[i] == tofindv) { 
                
                
                    count++;

                    if (count == 2) {


                        Console.WriteLine("second i postion " + i);
                    }
                }

            
            }
          
        }
    }
}
