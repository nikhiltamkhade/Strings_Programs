using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    // remove dublicate character from a string 
    internal class Remove_dublicate
    {
        public static void Main(string[] args)
        {

            //string dub = "nikhil";

            //string  result=new string(dub.Distinct().ToArray());  // this is another logic 

            //Console.WriteLine(result);


            string d = "nikhil";

            char[] ch=d.ToCharArray();

            string result="";

            for (int i = 0; i < ch.Length; i++)
            {
                if(!result.Contains(ch[i]))  // this condition check in result have dublicate character available ?;
                {
                    result+=ch[i];
                }
            }

            Console.WriteLine(result);

            Console.ReadLine();



        }
    }
}
