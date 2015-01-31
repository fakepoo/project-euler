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
        A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. 
        For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28
        is a perfect number.

        A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant
        if this sum exceeds n.

        As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as 
        the sum of two abundant numbers is 24. By mathematical analysis, it can be shown that all integers greater 
        than 28123 can be written as the sum of two abundant numbers. However, this upper limit cannot be reduced 
        any further by analysis even though it is known that the greatest number that cannot be expressed as the
        sum of two abundant numbers is less than this limit.

        Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
    */
    public class Problem_023
    {
        public static void Run()
        {
            int answer = 0;
            NumberType[] numberTypes = GetNumberTypes(28123);

            for (int i = 1; i < numberTypes.Length; i++)
            {
                if (!IsSumOfTwoAbundants(i, numberTypes)) answer += i;
            }
            
            Debug.WriteLine("The answer is " + answer);
        }

        public enum NumberType
        {
            Perfect,
            Deficient,
            Abundant,
        }

        public static NumberType GetNumberType(int n)
        {
            var divisors = Utility.GetDivisors(n);
            int sum = divisors.Sum();
            if (sum < n) return NumberType.Deficient;
            if (sum > n) return NumberType.Abundant;
            return NumberType.Perfect;
        }

        // max is not inclusive
        public static NumberType[] GetNumberTypes(int max)
        {
            NumberType[] result = new NumberType[max];

            for (int i = 1; i < max; i++)
            {
                result[i] = GetNumberType(i);
            }

            return result;
        }

        public static bool IsSumOfTwoAbundants(int n, NumberType[] numberTypes)
        {
            for (int i = 12; i < n; i++)
            {
                if (numberTypes[i] == NumberType.Abundant && numberTypes[n - i] == NumberType.Abundant) return true;
            }

            return false;
        }
    }
}
