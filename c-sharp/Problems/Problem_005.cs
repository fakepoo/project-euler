using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    /* 
        2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder. 
        What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    */
    public class Problem_005
    {
        public static void Run()
        {
            for (int number = 20 * 19; ; number += 20)
            {
                for (int i = 19; i > 1; i--)
                {
                    if (number % i > 0) break;

                    if (i == 2)
                    {
                        Debug.WriteLine("The answer is " + number);
                    }
                }
            }

            Debug.WriteLine("The answer is 1");
        }
    }
}
