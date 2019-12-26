using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_TA_n_FL_PR
{
    class Polinom
    {
        string allgood = "+-.";
        public List<Term> polinom { get; private set; }
        public Polinom(string s)
        {
            s += ".";
            bool spase = false;
            polinom = new List<Term>();
            int i = 0;
            string count = "";
            while (i < s.Length)
            {
                if(allgood.Contains(s[i].ToString()) && !spase )
                {
                    spase = true;
                    polinom.Add(new Term(count));
                    //i++;
                    count = "";
                }
                else
                {
                    count += s[i];
                    i++;
                    spase = false;
                }
            }
            polinom = getgoodPolinom().polinom;
        }
        public Polinom()
        {
            polinom = new List<Term>();
        }

        private Polinom getgoodPolinom()
        {
            Polinom res = new Polinom();
            for (int i = polinom.FirstOrDefault(t => t.pow.digit == polinom.Max(tt => tt.pow.digit)).pow.digit; i >= 0; i--)
            {
                if (polinom.FirstOrDefault(p => p.pow.digit == i) == null)
                {
                    continue;
                }
                var term = new Term(polinom.Where(s => s.pow.digit == i).Select(t => t.digit.digit).Sum(), i);
                res.polinom.Add(term);
                if (res.polinom.FirstOrDefault(p => p.digit.digit == 0) == null)
                {
                    res.polinom.Remove(term);
                }

            }
            return res;

        }
        public override string ToString()
        {
            string s="";
            for (int i = 0; i < polinom.Count; i++)
            {
                s += polinom[i].ToString();
            }
            return s;//убирает первый плюс если он есть
        }
    }
}
