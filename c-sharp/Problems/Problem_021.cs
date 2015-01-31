using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    /* 
        Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
        If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called 
        amicable numbers.

        For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; 
        therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.

        Evaluate the sum of all the amicable numbers under 10000.
    */
    public class Problem_021
    {
        public static void Run()
        {
            int answer = 0;

            int[] d_values = new int[10000];
            for (int i = 2; i < 10000; i++)
            {
                d_values[i] = d(i);
            }

            List<int> amicableNumbers = new List<int>();
            for (int a = 2; a < 10000; a++)
            {
                for (int b = a + 1; b < 10000; b++)
                {
                    if(d_values[a] == b && d_values[b] == a)
                    {
                        amicableNumbers.Add(a);
                        amicableNumbers.Add(b);
                    }
                }
            }

            answer = amicableNumbers.Distinct().Sum();

            Debug.WriteLine("The answer is " + answer);
        }

        public static int d(int n)
        {
            var divisors = Utility.GetDivisors(n);
            var sum = divisors.Sum();
            return sum;
        }

    }
}
