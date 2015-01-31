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
        n! means n × (n − 1) × ... × 3 × 2 × 1

        For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
        and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

        Find the sum of the digits in the number 100!
    */
    public class Problem_020
    {
        public static void Run()
        {
            BigInteger n = new BigInteger(100);
            for (int i = 99; i > 1; i--)
            {
                n *= i;
            }

            string s = n.ToString();

            int answer = 0;
            foreach(char c in s)
            {
                answer += int.Parse(c.ToString());
            }

            Debug.WriteLine("The answer is " + answer);
        }

    }
}
