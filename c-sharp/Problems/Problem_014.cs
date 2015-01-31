using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    /* 
        The following iterative sequence is defined for the set of positive integers:

        n → n/2 (n is even)
        n → 3n + 1 (n is odd)

        Using the rule above and starting with 13, we generate the following sequence:

        13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. 
        Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

        Which starting number, under one million, produces the longest chain?

        NOTE: Once the chain starts the terms are allowed to go above one million.
    */
    public class Problem_014
    {
        public static void Run()
        {
            long longestN = 0;
            long longestLength = 0;
            for(long n = 1; n < 1000000; n++)
            {
                long length = CollatzSequenceChainLength(n);

                if (n % 1000 == 0)
                {
                    Debug.WriteLine(string.Format("n = {0}, length = {1}", n, length));
                }

                if(length > longestLength)
                {
                    longestLength = length;
                    longestN = n;
                }
            }
            Debug.WriteLine(string.Format("The answer is {0} with a chain length of {1}", longestN, longestLength));
        }

        private static long CollatzSequenceChainLength(long n)
        {
            long length = 1;
            while(n != 1)
            {
                n = NextCollatzNumber(n);
                length++;
            }

            return length;
        }

        private static long NextCollatzNumber(long n)
        {
            if(n%2 == 0)
            {
                return n / 2;
            }

            return 3 * n + 1;
        }
    }
}
