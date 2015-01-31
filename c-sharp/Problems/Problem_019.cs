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
        You are given the following information, but you may prefer to do some research for yourself.

        1 Jan 1900 was a Monday.
        Thirty days has September,
        April, June and November.
        All the rest have thirty-one,
        Saving February alone,
        Which has twenty-eight, rain or shine.
        And on leap years, twenty-nine.
        A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
        How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
    */
    public class Problem_019
    {
        public static void Run()
        {
            DateTime startDate = new DateTime(1901, 1, 1);
            DateTime stopDate = new DateTime(2000, 12, 31);

            int sundays = 0;
            for(DateTime date = startDate; date <= stopDate; date = date.AddDays(1))
            {
                if (date.Day == 1 && date.DayOfWeek == DayOfWeek.Sunday)
                {
                    sundays++;
                    Debug.WriteLine(date.ToShortDateString());
                }
            }

            int answer = sundays;
            Debug.WriteLine("The answer is " + answer);
        }

    }
}
