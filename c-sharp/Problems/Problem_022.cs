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
        Using the 46K text file containing over five-thousand first names, begin by sorting it into alphabetical
        order. Then working out the alphabetical value for each name, multiply this value by its alphabetical 
        position in the list to obtain a name score.

        For example, when the list is sorted into alphabetical order, COLIN, which is worth 
        3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 
        938 × 53 = 49714.

        What is the total of all the name scores in the file?
    */
    public class Problem_022
    {
        public static void Run()
        {
            int colinScore = CalculateScore("COLIN", 938);

            string filename = @"Files\022.txt";
            string fileText = File.ReadAllText(filename);
            string[] names = fileText.Split(new char[] { ',' }).Select(s => s.Replace("\"", "").Trim()).OrderBy(s => s).ToArray();

            BigInteger answer = 0;
            for (int i = 0; i < names.Length; i++)
            {
                answer += CalculateScore(names[i], i + 1);
            }

            Debug.WriteLine("The answer is " + answer);
        }

        private static int CalculateScore(string s, int position)
        {
            int sum = s.ToCharArray().Select(c => c - 'A' + 1).Sum();
            int score = sum * position;
            return score;
        }
    }
}
