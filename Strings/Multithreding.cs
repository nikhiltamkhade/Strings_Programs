using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strings
{

    // this is synchronous example > this concept operation take place sequentially


    /*  internal class Multithreding
      {
          static void Main(string[] args)
          {
              Task1();
              Task2();  
              Console.ReadLine();
          }

          public static void Task1()
          {
              Console.WriteLine("task 1 starting ...");
              Thread.Sleep(4000);
              Console.WriteLine("task 1 compalete");

          }

          public static void Task2()
          {
              Console.WriteLine("task 2 starting...");
              Thread.Sleep(2000);
              Console.WriteLine("task 2 complete");
          }
    */


    // this is asynchronous concept > not execute in a sequence, not depend on each other

    internal class Multithreding
        {
              static void Main(string[] args)
              {
                 Task1();
                 Task2();
                 Task3();
                 Console.ReadLine();

              }

            public static async void Task1() 
             {
                await Task.Run(() =>
                {
                Console.WriteLine("task 1 is starting ");
                Thread.Sleep(5000);
                Console.WriteLine("task 1 completed");
                });
             }

        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("task 2 is starting ");
                Thread.Sleep(2000);
                Console.WriteLine("task 2 completed");
            });
        }


        public static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("task 3 is starting ");
                Thread.Sleep(1000);
                Console.WriteLine("task 3 completed");
            });
        }


        // below is return type of asynch 

        //Task: Use this return type when your asynchronous method does not return a value.

       /* public async Task PerformOperationAsync()
        {
            // Perform an operation asynchronously
            await Task.Delay(1000);
        }*/



        //Task<T>: Use this return type when your asynchronous method returns a value of type T.

       /* public async Task<int> CalculateAsync()
        {
            // Perform a calculation asynchronously
            await Task.Delay(1000);
            return 42;
        }*/




      //  void: Avoid using this return type for asynchronous methods as it makes error handling difficult.This return
      //  type is mainly used for event handlers.

        /*public async void OnButtonClick(object sender, EventArgs e)
        {
            await SomeAsyncOperation();
        }*/




    }

}
