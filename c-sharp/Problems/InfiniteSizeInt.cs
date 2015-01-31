using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class InfiniteSizeInt
    {
        private string _Number;

        public InfiniteSizeInt()
        {
            _Number = "0";
        }

        public override string ToString()
        {
            return _Number;
        }

        public static InfiniteSizeInt Parse(string s)
        {
            // Validate the input
            if (string.IsNullOrEmpty(s)) throw new Exception("Input does not represent an integer.");
            
            // Allow only numbers
            string allowed = "0123456789";
            foreach(char c in s)
            {
                if (!allowed.Contains(c)) throw new Exception("Input does not represent an integer.");
            }
            
            // Remove unnecessary leading zeros
            while(s.StartsWith("0") && s.Length > 1)
            {
                s = s.Remove(0, 1);
            }

            // Create the new struct
            InfiniteSizeInt number = new InfiniteSizeInt();
            number._Number = s;
            return number;
        }

        public InfiniteSizeInt Add(InfiniteSizeInt number)
        {
            StringBuilder sum = new StringBuilder();
            string n1 = this._Number;
            string n2 = number._Number;

            if(n1.Length > n2.Length)
            {
                n2 = new string('0', n1.Length - n2.Length) + n2;
            }
            else if (n2.Length > n1.Length)
            {
                n1 = new string('0', n2.Length - n1.Length) + n1;
            }

            int carry = 0;
            for (int i = n1.Length - 1; i >= 0; i--)
            {
                int digitSum = int.Parse(n1[i].ToString()) + int.Parse(n2[i].ToString()) + carry;
                if(digitSum > 9)
                {
                    carry = 1;
                    digitSum -= 10;
                }
                else
                {
                    carry = 0;
                }
                sum.Insert(0, digitSum);
            }

            // Add the final carry
            if (carry > 0) sum.Insert(0, carry);

            // Return the result;
            return InfiniteSizeInt.Parse(sum.ToString());            
        }
    }
}
