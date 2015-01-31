using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    /*
        The prime factors of 13195 are 5, 7, 13 and 29.
        What is the largest prime factor of the number 600851475143 ?
    */
    public class Problem_003
    {
        public static void Run()
        {
            long target = 600851475143;
            long largestFactor = 1;


            for (long i = 2; i * i < target; i++)
            {
                if (i % 1000 == 0) Debug.WriteLine(i);

                // Is it a prime factor?
                if (target % i == 0 && Utility.IsPrime(i))
                {
                    largestFactor = i;
                }
            }

            Debug.WriteLine("The answer is " + largestFactor);
        }
    }
}
