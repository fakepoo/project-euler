using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Utility
    {
        /*
         * A prime number is a natural number greater than 1 
         * that has no positive divisors other than 1 and itself. 
         */
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;

            for (int divisor = 2; divisor <= number / 2; divisor++)
            {
                if (number % divisor == 0) return false;
            }

            return true;
        }
        public static bool IsPrime(long number)
        {
            if (number <= 1) return false;

            for (long divisor = 2; divisor <= number / 2; divisor++)
            {
                if (number % divisor == 0) return false;
            }

            return true;
        }

        public static bool IsPalindrome(int number)
        {
            string s = number.ToString();
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - 1 - i]) return false;
            }

            return true;
        }

        
        public static int SumOfSquares(int number)
        {
            int sum = 0;

            for (int i = 1; i <= number; i++)
            {
                sum += (i * i);
            }

            return sum;
        }

        public static int SquareOfSum(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }

            return sum * sum;
        }

        public static int CountDivisors(int number)
        {
            int numberOfDivisors = 0;
            int squareRoot = (int)Math.Sqrt(number);

            for (int i = 1; i <= squareRoot; i++)
            {
                if (number % i == 0)
                {
                    numberOfDivisors += 2;
                }
            }

            return numberOfDivisors;
        }

        public static int[] GetDivisors(int number)
        {
            List<int> divisors = new List<int>();
            divisors.Add(1);
            
            int squareRoot = (int)Math.Sqrt(number);
            for (int i = 2; i <= squareRoot; i++)
            {
                if (number % i == 0)
                {
                    divisors.Add(i);
                    divisors.Add(number / i);
                }
            }            

            return divisors.Distinct().ToArray();
        }
    }
}
