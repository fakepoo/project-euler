using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    /* 
        By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        What is the 10 001st prime number?
    */
    public class Problem_007
    {
        public static void Run()
        {
            int primeCount = 0;

            for (long i = 2; ; i++)
            {
                if (Utility.IsPrime(i))
                {
                    primeCount++;

                    if (primeCount == 10001)
                    {
                        Debug.WriteLine("The answer is " + i);
                    }
                }
            }
        }
    }
}
