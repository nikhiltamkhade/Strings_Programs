using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Strings
{
    public class Remove_special_character
    {
        //static void Main(string[] args)
        //{
        //    string Schar = "Nikhil 123 @ $";
        //    string store = "";

        //    for (int i = 0; i < Schar.Length; i++)
        //    {
        //        if (Schar[i] == '@' || Schar[i] == '$')
        //        {
        //            store =store+Schar[i];
        //        }
        //        else 
        //        {
        //            Console.Write(Schar[i]);
        //        }
        //    }
        //    Console.ReadLine();

        //}

        // this is proper logic for any special character 
        static void Main()
        {
            string st = "nikhil@&t";

            // Keep only alphabets and numbers
            string cleanedString = Regex.Replace(st, "[^a-zA-Z0-9]", "");

            Console.WriteLine("Original String: " + st);
            Console.WriteLine("Cleaned String: " + cleanedString);
        }

    }
}
