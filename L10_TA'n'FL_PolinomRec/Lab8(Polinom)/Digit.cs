using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_TA_n_FL_PR
{
    class Digit
    {
        string numerals = "1234567890";
        public int digit=0;
        int signum = 1;
        public Digit(string s)
        {

            int i = 0;
            if (s.First() == '-') //проверяем знак
            {
                signum *= -1;
                i++;
            }
            if (s.First() == '+') i++;
            int k = 0;
            while(i< s.Length)
            {
                if (numerals.Contains(s[i]))
                    digit = digit * (int)Math.Pow(10, k++) + int.Parse(s[i++].ToString());
                  
            }
            if (i < s.Length) throw new FormatException();
            else digit *= signum;
        }
        public Digit(int d)
        {
            digit = d;
        }
    }
}
