using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
     public class Interview_program
    {

        // this program asked by interviewer for sandip pandhare 
        static void Main(string[] args)
        {
            string s = " success";
            for (int i = 0; i < s.Length-1; i++) {

                for (int j = i+1; j < s.Length-1; j++) { 
                
                    if (s[i] == s[j])
                    {
                        Console.WriteLine(s[j]);
                    }
                
                }
            
            }


        }
    }
}
