using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    /*
        A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit 
        numbers is 9009 = 91 × 99. Find the largest palindrome made from the product of two 3-digit numbers.
    */
    public class Problem_004
    {
        public static void Run()
        {
            int largestPalindrome = 0;

            for (int i = 1; i < 1000; i++)
            {
                for (int j = 1; j < 1000; j++)
                {
                    int palindrome = i * j;
                    if (palindrome > largestPalindrome && Utility.IsPalindrome(palindrome))
                    {
                        largestPalindrome = palindrome;
                    }
                }
            }

            Debug.WriteLine("The answer is " + largestPalindrome);
        }
    }
}
