using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] array1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            List<int> evens1List = new List<int>();
            List<int> odds2List = new List<int>();



            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            foreach (var num in array1) 

            {
                if (num % 2 == 0)
                {
                    evens1List.Add(num);
                }

                else
                {
                    odds2List.Add(num);
                }


            }


                  
            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            foreach (var num in evens1List)

            {

                Console.WriteLine(num);

                
            }
            foreach (var num in odds2List)

            {
                Console.WriteLine(num);
            }
              
            
        }


    }
}
