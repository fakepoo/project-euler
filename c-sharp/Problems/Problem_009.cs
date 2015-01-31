using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    /* 
        A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
        a^2 + b^2 = c^2

        For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

        There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        Find the product abc.
     */
    public class Problem_009
    {
        public static void Run()
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = 1; b + a < 1000; b++)
                {
                    int c = 1000 - a - b;
                    if (a * a + b * b == c * c)
                    {
                        Debug.WriteLine(string.Format("The answer (a, b, c) is ({0}, {1}, {2}) with a product of {3}", a, b, c, a*b*c));
                        return;
                    }
                }
            }
                   
        }
    }
}
