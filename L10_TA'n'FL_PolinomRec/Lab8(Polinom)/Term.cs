using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10_TA_n_FL_PR
{

    class Term
    {
        public Digit digit { get; private set; }
        public Pow pow { get; private set; }
        bool x = false;
        public Term(int d,int p)
        {
            digit = new Digit(  d);
           
            pow = new Pow( p);
        }

        public Term(string s)
        {

            int i = 0;
            while (i < s.Length)
            {
                  if (s[i] != 'x')
                    {
                        if (x)
                        {
                            if (s[i] == '^')
                            {
                                pow = new Pow(s.Substring(i + 1, s.Length - 1 - i));//-2
                                break;
                            }
                            else
                                throw new FormatException();//после x должна идти галочка иначе запись не верна

                        }
                        i++;

                    }
                    else
                    {
                        if (i++ == 0) digit = new Digit("1");
                        else
                            digit = new Digit(s.Substring(0, i - 1));
                        x = true;
                        //i++;//для того что бы перейти к галочке сразу мы ведь уже знаем что x есть
                    }
                
            }
            if(i==s.Length)//нет степени но дошли до конца(всё правильно)
            {
                if (x)
                    pow = new Pow("1");
                else
                {
                    digit = new Digit(s);
                    pow = new Pow("0");
                }
            }
            if (digit == null || pow == null)
                throw new FormatException();
        }

        public override string ToString()
        {
            string s = "";
            if (digit.digit > 0) s += "+";
            if (pow.digit == 0) s+= digit.digit.ToString();
            else s+= digit.digit + "x^" + pow.digit;
            return s;
        }
    }
}
