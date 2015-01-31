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
        A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the
        digits 1, 2, 3 and 4. If all of the permutations are listed numerically or alphabetically, we call it
        lexicographic order. The lexicographic permutations of 0, 1 and 2 are:

        012   021   102   120   201   210

        What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
    */
    public class Problem_024
    {
        public static void Run()
        {
            long answer = 0;
            int i = 0;
            for (int d0 = 0; answer == 0 && d0 < 10; d0++)
            {
                for (int d1 = 0; answer == 0 && d1 < 10; d1++)
                {
                    if (d1 == d0) continue;
                    for (int d2 = 0; answer == 0 && d2 < 10; d2++)
                    {
                        if(d2 == d1 || d2 == d0) continue;
                        for (int d3 = 0; answer == 0 && d3 < 10; d3++)
                        {
                            if (d3 == d2 || d3 == d1 || d3 == d0) continue;
                            for (int d4 = 0; answer == 0 && d4 < 10; d4++)
                            {
                                if (d4 == d3 || d4 == d2 || d4 == d1 || d4 == d0) continue;
                                for (int d5 = 0; answer == 0 && d5 < 10; d5++)
                                {
                                    if (d5 == d4 || d5 == d3 || d5 == d2 || d5 == d1 || d5 == d0) continue;
                                    for (int d6 = 0; answer == 0 && d6 < 10; d6++)
                                    {
                                        if (d6 == d5 || d6 == d4 || d6 == d3 || d6 == d2 || d6 == d1 || d6 == d0) continue;
                                        for (int d7 = 0; answer == 0 && d7 < 10; d7++)
                                        {
                                            if (d7 == d6 || d7 == d5 || d7 == d4 || d7 == d3 || d7 == d2 || d7 == d1 || d7 == d0) continue;
                                            for (int d8 = 0; answer == 0 && d8 < 10; d8++)
                                            {
                                                if (d8 == d7 || d8 == d6 || d8 == d5 || d8 == d4 || d8 == d3 || d8 == d2 || d8 == d1 || d8 == d0) continue;
                                                for (int d9 = 0; answer == 0 && d9 < 10; d9++)
                                                {
                                                    if (d9 == d8 || d9 == d7 || d9 == d6 || d9 == d5 || d9 == d4 || d9 == d3 || d9 == d2 || d9 == d1 || d9 == d0) continue;

                                                    i++;
                                                    if(i == 1000000)
                                                    {
                                                        answer = long.Parse(
                                                            d0.ToString() + 
                                                            d1.ToString() +
                                                            d2.ToString() +
                                                            d3.ToString() +
                                                            d4.ToString() +
                                                            d5.ToString() +
                                                            d6.ToString() +
                                                            d7.ToString() +
                                                            d8.ToString() +
                                                            d9.ToString()
                                                        );
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            Debug.WriteLine("The answer is " + answer);
        }
    }
}
