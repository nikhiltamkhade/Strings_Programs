using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class String_interpolation_concept
    {
        // Q= is what are string interpolation and string formating 
        // ans= string interpolation and string formating used embed variables inside the string but they have diffrent syntax

        // string interpolation
        static void Main(string[] args)
        {

            string name = "nikhil";
            int age = 25;

            string message = $"Hello, my name is {name} and I am {age} years old.";
            Console.WriteLine(message);
        }

        // string formating
        //string name = "Nikhil";
        //int age = 25;

        //string message = string.Format("Hello, my name is {0} and I am {1} years old.", name, age);
        //Console.WriteLine(message);


        // string concatenation (+operator)

         //string message = "Hello, my name is " + name + " and I am " + age + " years old.";



    }
}