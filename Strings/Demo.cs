using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Demo
    {


        public static void Main(string[] args)
        {
            string st = "nikhil shahaji tamkhade";


            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach(char c in st)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else { 
                dic[c] = 1;

                }
            }

            foreach (var c in dic) { 

                Console.WriteLine(c.Value+""+c.Key);
            

            
            }

        }

    }
}