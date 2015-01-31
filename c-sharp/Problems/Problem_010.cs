using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    /* 
        The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        Find the sum of all the primes below two million.     
     */
    public class Problem_010
    {
        public static void Run()
        {
            PrimeSieve primeSieve = new PrimeSieve(2000000 - 1);
            long sum = 0;
            var primes = primeSieve.Primes;
            foreach (int prime in primes)
            {
                sum += prime;
            }

            Debug.WriteLine("The answer is " + sum);
        }
    }
}
