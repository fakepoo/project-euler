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
        If the numbers 1 to 5 are written out in words: one, two, three, four, five, 
        then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.

        If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, 
        how many letters would be used?

        NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 
        23 letters and 115 (one hundred and fifteen) contains 20 letters. The use of "and" when writing 
        out numbers is in compliance with British usage.
    */
    public class Problem_017
    {
        public static void Run()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 1; i <= 1000; i++)
            {
                builder.Append(IntToWords(i));
            }
            int answer = builder.ToString().Length;

            Debug.WriteLine("The answer is " + answer);
        }

        public static string IntToWords(int x)
        {
            if (x > 1000 || x < 1) throw new ArgumentOutOfRangeException("x", "Acceptable range is 1 - 1000");

            if (x == 1000) return "onethousand";

            StringBuilder builder = new StringBuilder();
            
            string xAsString = x.ToString();
            // ensure 3 characters
            switch(xAsString.Length)
            {
                case 2:
                    xAsString = "0" + xAsString;
                    break;
                case 1:
                    xAsString = "00" + xAsString;
                    break;
            }

            // Handle the hundreds
            if (x >= 100)
            {                
                char hundredsDigit = xAsString[0];
                builder.Append(DigitToWord(hundredsDigit));
                builder.Append("hundred");
                if(xAsString.Substring(1,2) != "00")
                {
                    builder.Append("and");
                }
            }

            // Handle the tens
            switch(xAsString[1])
            {
                case '2':
                    builder.Append("twenty");
                    break;
                case '3':
                    builder.Append("thirty");
                    break;
                case '4':
                    builder.Append("forty");
                    break;
                case '5':
                    builder.Append("fifty");
                    break;
                case '6':
                    builder.Append("sixty");
                    break;
                case '7':
                    builder.Append("seventy");
                    break;
                case '8':
                    builder.Append("eighty");
                    break;
                case '9':
                    builder.Append("ninety");
                    break;
            }

            // Handle the ones
            if(xAsString[1] == '1')
            {
                switch(xAsString[2])
                {
                    case '0':
                        builder.Append("ten");
                        break;
                    case '1':
                        builder.Append("eleven");
                        break;
                    case '2':
                        builder.Append("twelve");
                        break;
                    case '3':
                        builder.Append("thirteen");
                        break;
                    case '4':
                        builder.Append("fourteen");
                        break;
                    case '5':
                        builder.Append("fifteen");
                        break;
                    case '6':
                        builder.Append("sixteen");
                        break;
                    case '7':
                        builder.Append("seventeen");
                        break;
                    case '8':
                        builder.Append("eighteen");
                        break;
                    case '9':
                        builder.Append("nineteen");
                        break;
                }
            }
            else
            {
                builder.Append(DigitToWord(xAsString[2]));
            }

            return builder.ToString();
        }

        public static string DigitToWord(char digit)
        {
            string result;
            switch(digit)
            {
                case '1':
                    result = "one";
                    break;
                case '2':
                    result = "two";
                    break;
                case '3':
                    result = "three";
                    break;
                case '4':
                    result = "four";
                    break;
                case '5':
                    result = "five";
                    break;
                case '6':
                    result = "six";
                    break;
                case '7':
                    result = "seven";
                    break;
                case '8':
                    result = "eight";
                    break;
                case '9':
                    result = "nine";
                    break;
                default:
                    result = string.Empty;
                    break;
            }
            return result;
        }
    }
}
