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
        2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.

        What is the sum of the digits of the number 2^1000?
    */
    public class Problem_016
    {
        public static void Run()
        {
            InfiniteSizeInt n = InfiniteSizeInt.Parse("2");

            for (int i = 1; i < 1000; i++)
            {
                n = n.Add(n);
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
