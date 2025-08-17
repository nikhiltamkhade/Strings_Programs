using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Methods_string
    {
        static void Main(string[] args)
        {




            string first = "nikhil    ";
            string second = "tamkhade";

            first = first.Trim();     // use of trim() = removing  whitespaces
            second = second.Trim();
            Console.WriteLine(first + second);



            //-------------- Remove()

            string N = "nikhil";
            N = N.Remove(3, 1);   // use of Remove= Remove specific index; >remove  nikil
            Console.WriteLine("remove  "+N);

            // ------------- Split()

            string nikhil = "my , name is | nikhil";
            string[] nt = nikhil.Split(',','|');

            for (int i = 0; i < nt.Length; i++)
            {
                Console.WriteLine(nt[i]);

            }

            //------------ ToLower() or ToUpper

            string Nt = "NIKHIL TAMKHADEe";
            Nt = Nt.ToLower();
            Console.WriteLine(Nt);

            // -----------IndexOf 
            string Nikhil = "tamkhade patil";
            int t= Nikhil.IndexOf('d');
            Console.WriteLine(t);

            // ------- string.Join()
            // combine array of string one with a separator

            string[] words = { "Dot", "Net", "Core" };
            string result=string.Join(" ",words);
            Console.WriteLine(result);

            // interview how handle null string 
            string nts = "";
            if (string.IsNullOrEmpty(nts))
            {
                Console.WriteLine("string is null");
            }

            if (string.IsNullOrWhiteSpace(nts))
            {
                Console.WriteLine("string is null");
            }



        }
    }
}
