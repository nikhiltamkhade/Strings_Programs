using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Remove_special_character
    {
        static void Main(string[] args)
        {
            string Schar = "Nikhil 123 @ $";
            string store = "";

            for (int i = 0; i < Schar.Length; i++)
            {
                if (Schar[i] == '@' || Schar[i] == '$')
                {
                    store =store+Schar[i];
                }
                else 
                {
                    Console.Write(Schar[i]);
                }
            }
            Console.ReadLine();
            
        }

        // this is proper logic for any special character 


        //static void Main(string[] args)
        //{
        //    string input = "nikhil@ tamkhade&#";
        //    string store = "";

        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        char c = input[i];

        //        if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
        //        {
        //            store += c;
        //        }
        //    }
        //    // we can use foreach loop

        //    //foreach (char ch in input)
        //    //{
        //    //    if (char.IsLetterOrDigit(ch) || char.IsWhiteSpace(ch)) // keep letters, digits, and spaces
        //    //    {
        //    //        result += ch;
        //    //    }
        //    //}
        //    Console.WriteLine("origanal" + input);
        //    Console.WriteLine("remove special character " + store);
        //}
    }
}
