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

            //  string is a sequence of characters used to represent text.


            //string first = "nikhil    ";
            //string second = "tamkhade";

            //first = first.Trim();     // use of trim() = removing  whitespaces
            //second = second.Trim();
            //Console.WriteLine(first+second);



            //-------------- Remove()

            //string N = "nikhil";
            //N = N.Remove(2,3);   // use of Remove= Remove specific index;
            //Console.WriteLine(N);

            // ------------- Split()

            //string nikhil = "my , name is | nikhil";
            //string[] nt = nikhil.Split(',', '|');
            ////Console.WriteLine(nt[0]);
            //for (int i = 0; i < nt.Length; i++)
            //{
            //    Console.WriteLine(nt[i]);

            //}

            //------------ ToLower() or ToUpper

            //string Nt = "NIKHIL TAMKHADE";
            //Nt= Nt.ToLower();
            //Console.WriteLine(Nt);

            // -----------IndexOf 
            string Nikhil = "tamkhade patil";
            int N = Nikhil.IndexOf('d');
            Console.WriteLine(N);



        }
    }
}
