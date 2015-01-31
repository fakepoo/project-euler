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
        Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, 
        there are exactly 6 routes to the bottom right corner.
        How many such routes are there through a 20×20 grid?   
    */
    public class Problem_015
    {
        // a 2x2 grid is represented by 3x3 array
        // hence, a 20x20 grid is represented by a 21x21 array
        private const int _Width = 21; 

        public static void Run()
        {
            long[,] combinations = new long[_Width, _Width];
            combinations[_Width - 1, _Width - 1] = 1;

            while(combinations[0,0] == 0)
            {
                ProcessCombinations(combinations);
            }
            long count = combinations[0, 0];
            Debug.WriteLine("The answer is " + count);

            string csv = ToCSV(combinations);
        }

        private static void ProcessCombinations(long[,] combinations)
        {
            for (int i = 0; i < _Width; i++)
            {
                for (int j = 0; j < _Width; j++)
                {
                    // Fill in the value in the array if possible

                    // Has it been filled in?
                    if(combinations[i,j] != 0) continue;

                    // Does it have an empty one to the right?
                    if (i < _Width - 1 && combinations[i + 1, j] == 0) continue;

                    // Does it have an empty one below it?
                    if (j < _Width - 1 && combinations[i, j + 1] == 0) continue;

                    long sum = 0;
                    if (i < _Width - 1) sum += combinations[i + 1, j];                    
                    if (j < _Width - 1) sum += combinations[i, j + 1];
                    combinations[i, j] = sum;
                }
            }
        }

        private static string ToCSV(long[,] combinations)
        {
            StringBuilder builder = new StringBuilder();

            for (int row = 0; row < _Width; row++)
            {
                for (int col = 0; col < _Width; col++)
                {
                    builder.Append(combinations[col, row]);

                    if (col < _Width - 1) builder.Append(',');
                    else builder.AppendLine();
                }
            }

            return builder.ToString();
        }
    }
}
