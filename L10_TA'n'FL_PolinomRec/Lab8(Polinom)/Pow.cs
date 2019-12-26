using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_TA_n_FL_PR
{

    class Pow
    {
        string numerals = "1234567890";
        public int digit = 0;

        public Pow(string s)
        {
            int i= 0;
            while (i < s.Length)
            {
                if (numerals.Contains(s[i]))
                    digit = digit*(int)Math.Pow(10, i) + int.Parse(s[i++].ToString());

            }
            if (i < s.Length) throw new FormatException();
        }
        public Pow(int p)
        {
            digit = p;
        }
    }
}
