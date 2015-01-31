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
        By starting at the top of the triangle below and moving to adjacent numbers on the row below, 
        the maximum total from top to bottom is 23.

           3
          7 4
         2 4 6
        8 5 9 3

        That is, 3 + 7 + 4 + 9 = 23.

        Find the maximum total from top to bottom of the triangle below:

    */
    public class Problem_067
    {
        public static void Run()
        {
            string filename = @"Files\067.txt";
            string s = File.ReadAllText(filename);

            TriangleTree tree = TriangleTree.Parse(s);
            Debug.WriteLine(tree.ToString());

            int answer = tree.CalculateMaximumPathSum();

            Debug.WriteLine("The answer is " + answer);
        }

    }
}
