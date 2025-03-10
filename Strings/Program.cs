using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string n = "nikhil tamkhade";
            string t = "patil";
            bool nt = string.IsNullOrEmpty(n);

            Console.WriteLine(nt);



            // Console.WriteLine(n.Trim()); // trim

            //  Console.WriteLine(string.Concat(n,t)); //  String Concat()
            //Console.WriteLine(n.CompareTo(t));  // compare to 

            //string[] s1 = { "Hello", "C#", "by", "javatpoint" };
            //string s3 = string.Join("*", s1);  //  this is jion methods
            //Console.WriteLine(s3);

            string b = "ndndnd";
            Console.WriteLine(b.ToUpper());
           
        }
    }
}
