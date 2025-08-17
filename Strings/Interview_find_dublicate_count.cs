using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Interview_find_dublicate_count
    {
        static void Main(string[] args)
        {
            string st = "india is my country";

            Dictionary<char, int> ch = new Dictionary<char, int>();

            foreach (char c in st.Replace(" ", ""))
            {

                if (ch.ContainsKey(c))
                    ch[c]++;

                else
                    ch[c] = 1;


            }

            foreach (var item in ch)
            {

                if (item.Value > 1)
                {

                    Console.WriteLine(item.Key + "" + item.Value);
                }


            }

        }
    }
}
