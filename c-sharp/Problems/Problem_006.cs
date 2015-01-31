using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    /* 
        The sum of the squares of the first ten natural numbers is,
        1^2 + 2^2 + ... + 10^2 = 385

        The square of the sum of the first ten natural numbers is,
        (1 + 2 + ... + 10)^2 = 55^2 = 3025

        Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
        Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    */
    public class Problem_006
    {
        public static void Run()
        {
            int sumOfSquares = Utility.SumOfSquares(100);
            int squareOfSum = Utility.SquareOfSum(100);

            int answer = squareOfSum - sumOfSquares;
            Debug.WriteLine("The answer is " + answer);
        }
    }
}
