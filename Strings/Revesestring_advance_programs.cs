using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Revesestring_advance_programs
    {
        static void Main(string[] args)
        {
            string str = "586";

            Console.WriteLine(Reverse(str));
            Console.ReadLine();
        }
        public static string Reverse(string nikhil)
        {
            if (nikhil == null)

                throw new ArgumentNullException(" null is not valid input");

            StringBuilder sb = new StringBuilder();
            char[] chars = nikhil.ToCharArray();

            for (int i = chars.Length - 1; i >= 0; i--)
            {

               sb.Append(chars[i]);
            }

            return sb.ToString();
        }

        
    }
}